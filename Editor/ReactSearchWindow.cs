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
using DifferentMethods.React.Generation;


namespace DifferentMethods.React.Editor
{

    public class ReactSearchWindow : EditorWindow, ISerializationCallbackReceiver
    {

        [System.Serializable]
        protected class SearchResult
        {
            public string niceName;
            public string signature;
            public Type type;
            public ReactCandidateClass candidateClass;
            public GUIContent content;
            public Reactor lib;
            public string superID;
        }

        public ReactEditor target;
        [SerializeField]
        public string generatedNodeToAdd = string.Empty;
        [SerializeField]
        public static ReactSearchWindow instance;

        int selectedSearchIndex = 0;
        int lastSelectedSearchIndex = -1;
        protected List<SearchResult> searchResults = new List<SearchResult>();

        string search = "";
        internal BaseNode lastHotNode = null;

        public void Update()
        {
            if (target != null && target.reactor != null && lastHotNode != target.reactor.hotNode)
            {
                lastHotNode = target.reactor.hotNode;
                UpdateSearchResults();
                Repaint();
            }
        }

        void OnDestroy()
        {
            SaveState();
            target.reactor.showExplorer = false;
        }

        public void OnAfterDeserialize()
        {
            instance = this;
        }

        [UnityEditor.Callbacks.DidReloadScripts]
        private static void OnScriptsReloaded()
        {
            if (instance == null) return;
            if (instance.generatedNodeToAdd != "" && instance.target != null)
                EditorApplication.delayCall += instance.AddNodeAfterCompile;
        }

        void AddNodeAfterCompile()
        {
            var newType = ReactTypeRegister.Find(instance.generatedNodeToAdd);
            if (!target.AddNode(newType))
            {
                Debug.LogError("Could not add new type: " + instance.generatedNodeToAdd);
            }
            generatedNodeToAdd = string.Empty;
            CloseAndSaveState();
        }

        public void LoadDefaultResults()
        {
            foreach (var registeredType in ReactTypeRegister.AllTypes)
            {
                var type = registeredType.type;
                if (ReactTypeRegister.IsCoreNode(type) || ReactTypeRegister.IsCoreDecorator(type))
                {
                    if (target.IsValidParent(registeredType.type, target.reactor.hotNode))
                        searchResults.Add(new SearchResult() { niceName = registeredType.niceName, type = registeredType.type, signature = registeredType.signature });
                }
            }
            searchResults.Sort((A, B) => A.niceName.CompareTo(B.niceName));

            titleContent = new GUIContent("Node Search", EditorGUIUtility.Load("React/ReactIcon.png") as Texture2D);
        }

        public void OnBeforeSerialize()
        {

        }

        void OnKey(Event e)
        {
            FocusSearchField();
            switch (e.keyCode)
            {
                case KeyCode.Escape:
                    search = "";
                    e.Use();
                    CloseAndSaveState();
                    break;
                case KeyCode.UpArrow:
                    selectedSearchIndex--;
                    if (selectedSearchIndex < 0)
                        selectedSearchIndex = searchResults.Count - 1;
                    e.Use();
                    break;
                case KeyCode.DownArrow:
                    selectedSearchIndex++;
                    if (selectedSearchIndex >= searchResults.Count)
                        selectedSearchIndex = 0;
                    e.Use();
                    break;
                case KeyCode.Return:
                case KeyCode.KeypadEnter:
                    AddSelectedSearchNode();
                    e.Use();
                    break;
            }
        }

        protected void AddNodeToTarget(SearchResult result, bool closeOnSuccess = true)
        {
            if (result.type != null)
            {
                if (target.AddNode(result.type) && closeOnSuccess)
                    CloseAndSaveState();
            }
            else if (result.candidateClass != null)
            {
                ShowNotification(new GUIContent("Compiling..."));
                generatedNodeToAdd = ReactGenerator.GetClass(result.candidateClass);
                EditorUtility.SetDirty(this);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
            else if (result.lib != null)
            {
                target.AddSuperCall(result.lib, result.superID);
                if (closeOnSuccess) CloseAndSaveState();
            }
        }

        void AddSelectedSearchNode()
        {
            if (selectedSearchIndex >= 0 && selectedSearchIndex <= searchResults.Count && searchResults.Count > 0)
            {
                AddNodeToTarget(searchResults[selectedSearchIndex]);
            }
            selectedSearchIndex = 0;
        }

        void FocusSearchField()
        {
            GUI.FocusControl("NodeSearch");
        }

        protected virtual void OnGUI()
        {
            if (Event.current.type == EventType.KeyDown) OnKey(Event.current);

            var rect = new Rect(5, 18, position.width - 10, 18);

            GUI.SetNextControlName("NodeSearch");
            var newSearch = GUI.TextField(rect, search);
            if (newSearch != search)
            {
                search = newSearch;
                UpdateSearchResults();
            }
            if (searchResults.Count > 0)
            {
                DrawSearchResults(rect);
            }
        }

        protected virtual void UpdateSearchResults()
        {
            searchResults.Clear();
            var qs = search.ToLower().Trim().Split(' ');
            foreach (var registeredType in ReactTypeRegister.AllTypes)
            {
                if (registeredType.niceName.ToLower() == search)
                {
                    searchResults.Insert(0, new SearchResult() { niceName = registeredType.niceName, type = registeredType.type, signature = registeredType.signature });
                    continue;
                }
                var add = true;
                foreach (var q in qs)
                {
                    if (!registeredType.niceName.ToLower().Contains(q))
                    {
                        add = false;
                    }
                }
                add = add && target.IsValidParent(registeredType.type, target.reactor.hotNode);
                if (add)
                    searchResults.Add(new SearchResult() { niceName = registeredType.niceName, type = registeredType.type, signature = registeredType.signature });
            }
            foreach (var candidate in ReactCandidateClass.AllCandidates)
            {
                if (candidate.NiceName.ToLower() == search)
                {
                    searchResults.Insert(0, new SearchResult() { niceName = candidate.NiceName, candidateClass = candidate, signature = candidate.Signature });
                    continue;
                }
                var add = true;
                foreach (var q in qs)
                {
                    if (!candidate.NiceName.ToLower().Contains(q))
                    {
                        add = false;
                    }
                }
                add = add && target.IsValidParent(candidate, target.reactor.hotNode);
                if (add)
                    searchResults.Add(new SearchResult() { niceName = candidate.NiceName, candidateClass = candidate, signature = candidate.Signature });
            }
            foreach (var i in AssetDatabase.FindAssets("t:GameObject"))
            {
                var go = AssetDatabase.LoadAssetAtPath<GameObject>(AssetDatabase.GUIDToAssetPath(i));
                var lib = go.GetComponent<Reactor>();
                if (lib)
                {
                    foreach (var super in lib.Exports)
                    {
                        if (super.id.ToLower() == search)
                        {
                            searchResults.Insert(0, new SearchResult() { niceName = super.id, lib = lib, superID = super.id });
                            continue;
                        }
                        var add = true;
                        foreach (var q in qs)
                        {
                            if (!super.id.ToLower().Contains(q))
                            {
                                add = false;
                            }
                        }
                        if (add)
                            searchResults.Add(new SearchResult() { niceName = super.id, lib = lib, superID = super.id });
                    }
                }
            }
        }

        public void SaveState()
        {
            EditorPrefs.SetFloat("React.Search.x", position.x);
            EditorPrefs.SetFloat("React.Search.y", position.y);
        }

        public void CloseAndSaveState()
        {
            SaveState();
            foreach (EditorWindow i in Resources.FindObjectsOfTypeAll(typeof(EditorWindow)))
            {
                if (target.IsInspectorEditor && i.GetType().Name == "InspectorWindow")
                {
                    i.Focus();
                    i.Repaint();
                }
                if (!target.IsInspectorEditor && i.GetType().Name == "ReactEditorWindow")
                {
                    i.Focus();
                    i.Repaint();
                    break;
                }
            }
            Close();
        }

        protected Texture2D GetIcon(Type nodeType)
        {
            if (nodeType == null)
                return EditorGUIUtility.Load("React/ReactDefaultIcon.png") as Texture2D;
            var tex = EditorGUIUtility.ObjectContent(null, nodeType).image;
            if (tex == null)
            {
                var icon = "";
                var s = nodeType.Name;
                if (s.StartsWith("If") || s.StartsWith("Condition"))
                    icon = "Condition";
                else
                    icon = nodeType.Name;

                tex = EditorGUIUtility.Load("React/" + icon + ".png") as Texture2D;
                if (tex == null)
                    tex = EditorGUIUtility.Load("React/ReactDefaultIcon.png") as Texture2D;
            }
            return tex as Texture2D;
        }

        protected void DrawSearchResults(Rect rect)
        {

            if (Event.current.isScrollWheel)
            {
                var d = Event.current.delta.y;
                selectedSearchIndex += (int)(Mathf.Sign(d) * Mathf.Clamp(d, 1, 99));
            }

            if (selectedSearchIndex >= searchResults.Count)
                selectedSearchIndex = searchResults.Count - 1;
            if (selectedSearchIndex < 0)
                selectedSearchIndex = 0;

            if (lastSelectedSearchIndex != selectedSearchIndex)
            {
                lastSelectedSearchIndex = selectedSearchIndex;
            }

            using (var scrollView = new GUI.ScrollViewScope(new Rect(0, rect.yMax, position.width, position.height - rect.yMax), searchScrollPosition, searchViewRect))
            {
                searchScrollPosition = scrollView.scrollPosition;
                var index = 0;
                var cc = GUI.contentColor;
                var row = new Rect(0, 0, position.width, 24);
                var style = new GUIStyle(GUI.skin.textField);
                style.alignment = TextAnchor.MiddleLeft;
                style.fontStyle = FontStyle.Bold;
                style.imagePosition = ImagePosition.ImageLeft;
                foreach (var result in searchResults)
                {
                    if (row.y > searchScrollPosition.y - row.height && row.y < position.height + searchScrollPosition.y)
                    {
                        if (result.content == null)
                            result.content = new GUIContent(result.niceName + " " + result.signature, GetIcon(result.type));
                        var contentColor = result.candidateClass == null ? Color.white : Color.yellow;
                        if (index == selectedSearchIndex)
                        {
                            if (row.y >= searchScrollPosition.y)
                            {
                                searchScrollPosition.y = row.y;
                            }
                            if (row.y <= searchScrollPosition.y)
                            {
                                searchScrollPosition.y = row.y;
                            }
                            GUI.contentColor = contentColor;
                        }
                        else
                        {
                            GUI.contentColor = contentColor *= 0.8f;
                        }

                        if (GUI.Button(row, result.content, style))
                        {
                            AddNodeToTarget(result);
                        }
                    }
                    row.y += row.height + 1;
                    index += 1;
                }
                GUI.contentColor = cc;
                searchViewRect = new Rect(0, 0, row.xMax - 16, row.yMax);
            }
        }
        Rect searchViewRect;
        Vector2 searchScrollPosition;

    }

}
