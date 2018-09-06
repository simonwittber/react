using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Text;
using UnityEditor.Callbacks;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using DifferentMethods.React.Components;

namespace DifferentMethods.React.Editor
{


    public partial class ReactEditor
    {
        static Vector2 SPACING = new Vector2(16, 7);
        static float ROWHEIGHT = 24;

        internal static List<string> labels = new List<string>();
        internal static Dictionary<string, System.Type> references = new Dictionary<string, System.Type>();

        [SerializeField] internal Rect viewRect;
        [SerializeField] internal Rect cullRect;

        Root root;
        [SerializeField] BaseNode clipboard;

        [NonSerialized] BaseNode dragNode;

        Rect cursor;
        bool focusFirstControl = false;
        event System.Action schedule;

        Vector2 mousePosition;

        GUIStyle style;
        ReactExplorerWindow paletteWindow;
        ReactSearchWindow searchWindow;
        BaseNode lastHotNode = null;

        public bool IsInspectorEditor
        {
            get
            {
                return !reactor.goLarge;
            }
        }

        void DrawExecutionState(BaseNode node)
        {
            var stateColor = new Color(1, 1, 1, 0);
            if (Application.isPlaying)
            {
                switch (node.lastState)
                {
                    case NodeState.Aborted: stateColor = Color.magenta; break;
                    case NodeState.Success: stateColor = Color.green; break;
                    case NodeState.Failure: stateColor = Color.red; break;
                    case NodeState.NoResult: stateColor = Color.white; break;
                }
                if (node.lastState != NodeState.None)
                    stateColor.a = 0.7f * Mathf.Clamp01(1 - ((Time.time - node.lastExecuteTime)));
                ReactEditorUtility.DrawOutline(node.rect, stateColor, stateColor / 2);
            }

        }

        void PreProcessGraph(Root root, BaseNode node)
        {
            if (node is Label)
            {
                labels.Add(((Label)node).id);
            }
            foreach (var fi in ReactTypeRegister.GetFields(node))
            {

            }
            var branch = node as BranchNode;
            if (branch != null)
            {
                foreach (var child in branch.Children)
                {
                    PreProcessGraph(root, child);
                }
            }
            var decorator = node as DecoratorNode;
            if (decorator != null && decorator.Child != null)
            {
                PreProcessGraph(root, decorator.Child);
            }
        }

        void DrawRoot(Root root)
        {
            if (root != null)
            {
                {
                    root.rect.x += 3;
                    var rect = root.rect;
                    rect.x += rect.width;
                    rect.width = 96;
                    if (GUI.Button(rect, "Add Event"))
                    {
                        ShowRootContextMenu();
                    }

                    rect.x += rect.width + 16;
                    rect.width = 24;
                    var explorer = EditorGUIUtility.LoadRequired("React/explorer.png") as Texture2D;
                    var oldShowExplorer = reactor.showExplorer;
                    reactor.showExplorer = GUI.Toggle(rect, reactor.showExplorer, explorer, "button");
                    if (reactor.showExplorer != oldShowExplorer)
                        if (reactor.showExplorer)
                        {
                            if (paletteWindow == null)
                                paletteWindow = ScriptableObject.CreateInstance<ReactExplorerWindow>();
                            paletteWindow.target = this;
                            var wrect = new Rect(0, 0, 384, 512);
                            wrect.x = EditorPrefs.GetFloat("React.Search.x", 50);
                            wrect.y = EditorPrefs.GetFloat("React.Search.y", 50);
                            paletteWindow.position = wrect;
                            paletteWindow.ShowUtility();
                        }
                        else
                        {
                            if (paletteWindow != null)
                            {
                                paletteWindow.CloseAndSaveState();
                                paletteWindow = null;

                            }
                        }

                    rect.x += rect.width + 8;

                    var maximise = EditorGUIUtility.LoadRequired("React/maximise.png") as Texture2D;
                    var minimise = EditorGUIUtility.LoadRequired("React/minimise.png") as Texture2D;
                    if (GUI.Button(rect, reactor.goLarge ? minimise : maximise))
                    {
                        reactor.goLarge = !reactor.goLarge;
                        if (reactor.goLarge)
                        {
                            var w = EditorWindow.GetWindow<ReactEditorWindow>();
                            w.Show();
                        }
                        else
                        {
                            Selection.activeGameObject = reactor.gameObject;
                        }
                    }

                    root.rect.xMax = rect.xMax;
                }
            }
        }

        void DrawBranch(BranchNode branch)
        {
            //if node is a branch, draw children and widgets.
            if (branch != null)
            {
                cursor.x += SPACING.x;
                var top = branch.rect.yMax;
                var bottom = branch.rect.yMax;
                for (int i = 0; i < branch.Children.Count; i++)
                {
                    var c = branch.Children[i];
                    if (c != null)
                    {
                        Draw(c, branch);
                        bottom = c.rect.center.y;
                        dropZones.Add(new DropZone(branch, c.rect, i));

                        if (i == branch.Children.Count - 1)
                            dropZones.Add(new DropZone(branch, c.rect, i + 1, true));
                    }
                }
                var left = branch.rect.x + (SPACING.x / 2);
                ReactEditorUtility.DrawLine(new Vector2(left, top), new Vector3(left, bottom), Color.white);
                cursor.x -= SPACING.x;
            }
        }

        void DrawCoreDecorator(DecoratorNode decorator)
        {
            // var rect = decorator.rect;
            //rect.xMax = EditorGUIUtility.currentViewWidth;
            //decorator.rect.xMax = rect.xMax - 15;
            //ReactEditorUtility.DrawOutline(decorator.rect, Color.white / 2f, Color.blue * 0, 1);
        }

        void DrawDecorator(DecoratorNode decorator)
        {
            //if node is a decorator, draw child and widgets.
            if (decorator != null)
            {
                if (ReactTypeRegister.IsCoreDecorator(decorator.GetType()))
                {
                    DrawCoreDecorator(decorator);
                }
                if (decorator.Child != null)
                {
                    cursor.x += decorator.rect.width + SPACING.x;
                    cursor.y -= decorator.rect.height + SPACING.x / 2;
                    Draw(decorator.Child, decorator);
                    // var left = decorator.rect.xMax;
                    // var mid = decorator.rect.center.y;
                    // var right = decorator.Child.rect.xMin;
                    // ReactEditorUtility.DrawLine(new Vector2(left, mid), new Vector3(right, mid), Color.white);
                    cursor.x -= decorator.rect.width + SPACING.x;
                }
                dropZones.Add(new DropZone(decorator, decorator.rect));

            }
        }

        Texture2D GetIcon(BaseNode node)
        {
            var s = node.ToString();
            var icon = "";
            if (s.StartsWith("IF") || s.StartsWith("CHECK"))
                icon = "Condition";
            else
                icon = node.GetType().Name;

            var tex = EditorGUIUtility.Load("React/" + icon + ".png");
            if (tex == null)
                tex = EditorGUIUtility.Load("React/ReactDefaultIcon.png");
            return tex as Texture2D;
        }

        bool IsVisible(BaseNode node)
        {
            return ((node.rect.yMin < cullRect.yMax && node.rect.yMax > cullRect.yMin) && (node.rect.xMin < cullRect.xMax && node.rect.xMax > cullRect.xMin));
        }

        void Draw(BaseNode node, BaseNode parent)
        {
            if (node == null)
                return;
            var visible = IsVisible(node);
            node.nodeParent = parent;
            node.rect.y = cursor.y;
            GUI.color = Color.white;
            if (visible) ReactEditorUtility.DrawBackground(node.rect, reactor.hotNode == node && dragNode == null ? style : GUI.skin.box);
            node.rect = cursor;
            if (visible)
            {
                if (node is Comment && reactor.hotNode != node)
                {
                    var comment = node as Comment;
                    var oc = new GUIContent(comment.text);
                    //draw node contents
                    var size = EditorStyles.boldLabel.CalcSize(oc);
                    node.rect.width = size.x + 32;
                    node.rect.height = size.y * 2;
                    EditorGUI.HelpBox(node.rect, comment.text, MessageType.Info);
                    // GUI.Label(node.rect, oc, EditorStyles.boldLabel);
                }
                else
                {
                    Texture icon = null;
                    icon = EditorGUIUtility.ObjectContent(null, node.GetWrappedType()).image;
                    if (node != root)
                    {
                        if (icon == null)
                            icon = GetIcon(node);
                        var oc = new GUIContent(node.ToString());
                        //draw node contents
                        var size = EditorStyles.boldLabel.CalcSize(oc);
                        oc.image = icon;
                        node.rect.width = size.x + 32;
                        GUI.Label(node.rect, oc, EditorStyles.boldLabel);
                    }
                    var focus = false;
                    if (focusFirstControl && reactor.hotNode == node)
                    {
                        focus = true;
                        focusFirstControl = false;
                    }
                    ReactFieldEditor.DrawFields(node, focus, reactor.hotNode == node);
                }
            }

            var left = 0f;
            if (node.nodeParent != null)
            {
                if (node.nodeParent is DecoratorNode)
                    left = node.nodeParent.rect.xMax;
                else
                    left = node.nodeParent.rect.x + (SPACING.x / 2);
            }
            var top = node.rect.center.y;
            var right = node.rect.x;
            ReactEditorUtility.DrawLine(new Vector2(left, top), new Vector3(right, top), Color.white);
            cursor.y += node.rect.height + SPACING.y;
            if (visible) DrawExecutionState(node);
            DrawRoot(node as Root);
            DrawBranch(node as BranchNode);
            DrawDecorator(node as DecoratorNode);
            viewRect.xMax = Mathf.Max(viewRect.xMax, node.rect.xMax + 32);
            viewRect.yMax = Mathf.Max(viewRect.yMax, node.rect.yMax + 8);
        }

        internal void AddNodeFromRootMenu(object nodeType)
        {
            reactor.hotNode = root;
            AddNode(nodeType);
        }

        internal bool AddNode(object nodeType)
        {
            var newNodeType = nodeType as System.Type;
            if (newNodeType != null)
            {
                if (!IsValidParent(newNodeType, reactor.hotNode))
                {
                    ShowNotification(new GUIContent("Active node is an invalid parent."));
                    EditorApplication.Beep();
                    return false;
                }
                var branch = reactor.hotNode as BranchNode;
                if (branch != null)
                {
                    var newNode = Activator.CreateInstance(newNodeType) as BaseNode;
                    branch.Add(newNode);
                    reactor.hotNode = newNode;
                    focusFirstControl = true;
                    EditorUtility.SetDirty(target);
                    Repaint();
                    return true;
                }
                var decorator = reactor.hotNode as DecoratorNode;
                if (decorator != null)
                {
                    if (decorator.Child == null)
                    {
                        var newNode = Activator.CreateInstance(newNodeType) as BaseNode;
                        decorator.SetChild(newNode);
                        reactor.hotNode = newNode;
                        focusFirstControl = true;
                    }
                    else if (newNodeType.IsSubclassOf(typeof(DecoratorNode)))
                    {
                        reactor.hotNode = decorator.Child;
                        DecorateHotNode(newNodeType);
                    }
                    else
                    {
                        Debug.LogWarning("Please delete the child node first.");
                    }
                    EditorUtility.SetDirty(target);
                    Repaint();
                    return true;
                }
            }
            return false;
        }

        internal bool AddSuperCall(Reactor lib, string superID)
        {
            if (!IsValidParent(typeof(SuperCall), reactor.hotNode))
            {
                ShowNotification(new GUIContent("Active node is an invalid parent."));
                EditorApplication.Beep();
                return false;
            }
            var newNode = Activator.CreateInstance(typeof(SuperCall)) as SuperCall;
            newNode.lib = lib;
            newNode.id = superID;
            var branch = reactor.hotNode as BranchNode;
            if (branch != null)
                branch.Add(newNode);
            var decorator = reactor.hotNode as DecoratorNode;
            if (decorator != null)
                decorator.SetChild(newNode);
            reactor.hotNode = newNode;
            var super = lib.GetExport(superID);
            if (super != null)
                foreach (var p in super.ParameterNodes)
                    newNode.Add(BaseNode.Clone(p));
            focusFirstControl = true;
            EditorUtility.SetDirty(target);
            Repaint();
            return true;
        }

        void ShowNotification(GUIContent guiContent)
        {
            EditorWindow.focusedWindow.ShowNotification(guiContent);
        }

        [DidReloadScripts]
        static void CreateMissingTypes()
        {
            var refresh = false;
            foreach (var i in ReactSerializer.missingTypes)
            {
                var rcc = DifferentMethods.React.Generation.ReactCandidateClass.Find(i);
                if (rcc != null)
                {
                    refresh = true;
                    DifferentMethods.React.Generation.ReactGenerator.GetClass(rcc);
                    Debug.Log("Creating new class: " + i);
                }
            }
            if (refresh)
            {
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
        }

        public void OnGUI()
        {
            if (target == null) return;
            reactor = target as Reactor;
            root = reactor.Root;
            if (root == null) return;
            if (reactor.hotNode == root)
            {
                if (root.ChildCount > 0)
                    reactor.hotNode = root.Children[0];
                else
                    reactor.hotNode = null;
            }
            root.Reactor = reactor;
            if (lastHotNode != reactor.hotNode)
            {
                lastHotNode = reactor.hotNode;
                if (paletteWindow != null) paletteWindow.Update();
                if (searchWindow != null) searchWindow.Update();
            }
            position = GUILayoutUtility.GetRect(Mathf.Min(EditorGUIUtility.currentViewWidth - 64, viewRect.width), viewRect.height);

            mousePosition = Event.current.mousePosition;
            PreProcessGraph(root, root);
            root.OnValidate();

            if (style == null)
            {
                style = new GUIStyle(GUI.skin.box);
                style.normal.background = EditorGUIUtility.LoadRequired("React/decorator.psd") as Texture2D;
                style.border = new RectOffset(16, 16, 16, 16);
                style.overflow = new RectOffset(6, 6, 6, 6);
            }

            if (Event.current.type == EventType.Repaint)
            {
                if (schedule != null)
                {
                    schedule();
                    schedule = null;
                }
            }
            dropZones.Clear();
            OnValidateGUIState();
            ProcessGUIEvents();
            viewRect = position;
            cursor = new Rect(0, position.y + 15, 1, ROWHEIGHT);
            EditorGUI.BeginChangeCheck();
            if (focusFirstControl) GUI.FocusControl("FirstFocus");
            Draw(root, null);
            if (EditorGUI.EndChangeCheck() && target != null)
                EditorUtility.SetDirty(target);
            OnGUIHasBeenDrawn();
        }

        void DecorateHotNode(object t)
        {
            var parent = reactor.hotNode.nodeParent as IParentNode;
            if (parent == null)
                return;
            var type = (System.Type)t;
            var currentNode = reactor.hotNode;
            var newNode = Activator.CreateInstance(type) as IParentNode;
            if (newNode == null)
                return;
            parent.Insert(parent.IndexOf(currentNode), (BaseNode)newNode);
            parent.Remove(currentNode);
            newNode.Add(currentNode);
            reactor.hotNode = (BaseNode)newNode;
            EditorUtility.SetDirty(target);
        }

        void ProcessGUIEvents()
        {
            Event e = Event.current;

            EditorGUI.BeginChangeCheck();

            if (e.type == EventType.ValidateCommand && reactor.hotNode != null && !EditorGUIUtility.editingTextField)
            {
                switch (e.commandName)
                {
                    case "Paste":
                        e.Use();
                        break;
                    case "Duplicate":
                        e.Use();
                        break;
                    case "Copy":
                        e.Use();
                        break;
                    case "Cut":
                        e.Use();
                        break;
                    case "Delete":
                        e.Use();
                        break;
                }
            }
            if (e.type == EventType.ExecuteCommand && reactor.hotNode != null && !EditorGUIUtility.editingTextField)
            {
                switch (e.commandName)
                {
                    case "Paste":
                        OnPaste();
                        return;
                    case "Duplicate":
                        OnDuplicate();
                        return;
                    case "Copy":
                        OnCopy();
                        return;
                    case "Cut":
                        OnCut();
                        return;
                    case "Delete":
                        OnDelete();
                        return;
                }
            }
            if (e.isKey && e.type == EventType.KeyDown && e.keyCode != KeyCode.None)
                OnKey(e);


            if (e.isMouse && e.type == EventType.MouseDown)
            {
                if (SelectHotNode(e, root))
                {
                    EditorGUI.FocusTextInControl("");
                    EditorGUIUtility.editingTextField = false;
                }
                if (reactor.hotNode != null && e.button == 1)
                    schedule += ShowContextMenu;
            }
        }

        void ShowSearchWindow()
        {
            searchWindow = EditorWindow.GetWindow<ReactSearchWindow>();
            searchWindow.target = this;
            searchWindow.lastHotNode = reactor.hotNode;
            searchWindow.LoadDefaultResults();
            searchWindow.ShowAsDropDown(reactor.hotNode.rect, new Vector2(384, 512));
            var rect = new Rect(0, 0, 384, 512);
            rect.x = EditorPrefs.GetFloat("React.Search.x", 50);
            rect.y = EditorPrefs.GetFloat("React.Search.y", 50);
            searchWindow.position = rect;
        }

        void ShowContextMenu()
        {
            if (reactor.hotNode == root)
                ShowRootContextMenu();
            else
                ShowNodeContextMenu();
        }

        void ShowNodeContextMenu()
        {
            var menu = new GenericMenu();
            if (reactor.hotNode is IParentNode)
                menu.AddItem(new GUIContent("Add Child"), false, ShowSearchWindow);
            else
                menu.AddDisabledItem(new GUIContent("Add Child"));

            foreach (var i in ReactTypeRegister.CoreTypes)
            {
                if (i.type == typeof(Root))
                    continue;
                menu.AddItem(new GUIContent("Insert Parent/" + i.menuPath), false, DecorateHotNode, i.type);
            }
            menu.AddSeparator("");
            menu.AddItem(new GUIContent("Cut"), false, OnCut);
            menu.AddItem(new GUIContent("Copy"), false, OnCopy);
            menu.AddItem(new GUIContent("Paste"), false, OnPaste);
            menu.AddItem(new GUIContent("Duplicate"), false, OnDuplicate);
            menu.AddItem(new GUIContent("Delete"), false, OnDelete);

            menu.AddSeparator("");
            menu.AddItem(new GUIContent("Edit source"), false, delegate ()
            {
                OpenTypeFile(reactor.hotNode.GetType());
            });
            menu.ShowAsContext();
        }

        public static void OpenTypeFile(System.Type type, int line = 1)
        {
            string path = GetFilePathOfType(type);
            if (string.IsNullOrEmpty(path) == false)
            {
                UnityEditorInternal.InternalEditorUtility.OpenFileAtLineExternal(path, line);
            }
            else
            {
                Debug.Log(string.Format("File of type '{0}' not found!", type.Name));
            }
        }

        public static void OpenTypeFile(string typePath)
        {
            if (string.IsNullOrEmpty(typePath) == false)
            {
                UnityEditorInternal.InternalEditorUtility.OpenFileAtLineExternal(typePath, 1);
            }
        }

        public static string GetFilePathOfType(System.Type type)
        {
            string[] foundFiles = Directory.GetFiles(Application.dataPath, type.Name + ".cs", SearchOption.AllDirectories);
            if (foundFiles.Length > 0)
            {
                return foundFiles[0];
            }
            else
            {
                return string.Empty;
            }
        }

        void ShowRootContextMenu()
        {
            var menu = new GenericMenu();
            foreach (var i in ReactTypeRegister.CoreDecoratorTypes)
                menu.AddItem(new GUIContent(i.menuPath), false, AddNodeFromRootMenu, i.type);
            menu.ShowAsContext();
        }

        bool SelectHotNode(Event e, BaseNode node)
        {
            if (node == null) return false;
            var mp = e.mousePosition;
            mp.x -= position.x;
            mp.y -= position.y;
            if (node.rect.Contains(mp))
            {
                reactor.hotNode = node;
                return true;
            }
            var branch = node as BranchNode;
            var decorator = node as DecoratorNode;
            if (branch != null)
            {
                foreach (var child in branch.Children)
                {
                    if (SelectHotNode(e, child))
                        return true;
                }
            }
            if (decorator != null && decorator.Child != null)
            {
                if (SelectHotNode(e, decorator.Child))
                    return true;
            }
            return false;
        }

        void OnValidateGUIState()
        {
            if (reactor.hotNode == null)
                reactor.hotNode = root;
        }




    }

}







