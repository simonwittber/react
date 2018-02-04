using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEditor.SceneManagement;
using DifferentMethods.React.Generation;

namespace DifferentMethods.React.Editor
{

    public partial class ReactEditor
    {
        bool IsValidParent(BaseNode child, BaseNode parent)
        {
            if (child == null || parent == null) return false;
            return IsValidParent(child.GetType(), parent);
        }

        internal bool IsValidParent(ReactCandidateClass candidate, BaseNode parent)
        {
            if (!(parent is IParentNode)) return false;
            return true;
        }

        internal bool IsValidParent(System.Type childType, BaseNode parent)
        {
            var childIsCore = ReactTypeRegister.IsCoreDecorator(childType);
            if (childType == typeof(Root)) return false;
            var parentIsRoot = parent == root;
            if (parentIsRoot && !childIsCore)
                return false;
            if (parentIsRoot && childIsCore && childType != typeof(OnMessage))
            {
                foreach (var child in ((IParentNode)parent).GetChildren())
                {
                    if (child.GetType() == childType) return false;
                }
            }
            if (!(parent is IParentNode)) return false;
            if (childIsCore && !parentIsRoot) return false;
            return true;
        }

        void CheckRootFolders()
        {
            var marker = EditorGUIUtility.Load("React/REACT_EDITOR_RESOURCES.txt");
            if (marker == null)
            {
                Debug.Log("React is copying required root folders into your project.");
                var folderPath = System.IO.Path.GetDirectoryName(AssetDatabase.GUIDToAssetPath(AssetDatabase.FindAssets("t:TextAsset REACT_ROOT_FOLDERS")[0]));
                System.IO.Directory.CreateDirectory("Assets/Editor Default Resources");
                System.IO.Directory.CreateDirectory("Assets/Gizmos");
                FileUtil.CopyFileOrDirectory(folderPath + "/Editor Default Resources/React", "Assets/Editor Default Resources/React");
                FileUtil.CopyFileOrDirectory(folderPath + "/Gizmos/React", "Assets/Gizmos/React");
                AssetDatabase.Refresh();
            }
        }

        void OnEnable()
        {
            Undo.undoRedoPerformed += UndoRedoPerformed;
            CheckRootFolders();
        }

        void OnDestroy()
        {
            Undo.undoRedoPerformed -= UndoRedoPerformed;
        }

        void UndoRedoPerformed()
        {
            if (target != null)
                EditorUtility.SetDirty(target);
        }

        void OnPaste()
        {
            if (clipboard == null) return;
            if (!IsValidParent(clipboard, reactor.hotNode))
            {
                ShowNotification(new GUIContent("Active node is an invalid parent."));
                EditorApplication.Beep();
                return;
            }
            var node = BaseNode.Clone(clipboard);
            var parent = reactor.hotNode as IParentNode;
            if (parent != null)
            {
                Undo.RegisterCompleteObjectUndo(target, "Paste");
                parent.Add(node);
            }
            else
            {
                Undo.RegisterCompleteObjectUndo(target, "Paste");
                parent = reactor.hotNode.nodeParent as IParentNode;
                parent.Insert(parent.IndexOf(reactor.hotNode), node);
            }
            reactor.hotNode = node;
            EditorUtility.SetDirty(target);
        }

        void OnCut()
        {
            OnCopy();
            OnDelete();
        }

        void OnCopy()
        {
            clipboard = BaseNode.Clone(reactor.hotNode);
        }

        void OnDuplicate()
        {
            Undo.RecordObject(target, "Duplicate");
            if (!IsValidParent(reactor.hotNode, reactor.hotNode.nodeParent))
            {
                ShowNotification(new GUIContent("You cannot duplicate this node."));
                EditorApplication.Beep();
                return;
            }
            var dupe = BaseNode.Clone(reactor.hotNode);
            var parent = reactor.hotNode.nodeParent as IParentNode;
            var index = parent.IndexOf(reactor.hotNode);
            parent.Insert(index + 1, dupe);
            reactor.hotNode = dupe;
            EditorUtility.SetDirty(target);
        }

        void OnDelete()
        {
            var parent = reactor.hotNode.nodeParent as IParentNode;
            if (parent != null)
            {
                Undo.RegisterCompleteObjectUndo(target, "Delete");
                var index = parent.IndexOf(reactor.hotNode) - 1;
                parent.Remove(reactor.hotNode);
                if (index < 0)
                    reactor.hotNode = reactor.hotNode.nodeParent;
                else
                    reactor.hotNode = parent.GetChild(index);
                EditorUtility.SetDirty(target);
            }
        }

        void OnKey(Event e)
        {
            if (reactor.hotNode == null || EditorGUIUtility.editingTextField)
                return;

            if (e.keyCode == KeyCode.Space && !EditorGUIUtility.editingTextField)
            {
                if (reactor.hotNode is LeafNode)
                {
                    reactor.hotNode = reactor.hotNode.nodeParent;
                }
                if (reactor.hotNode is BranchNode || reactor.hotNode is DecoratorNode)
                {
                    if (reactor.hotNode == root)
                        ShowContextMenu();
                    else
                        ShowSearchWindow();
                }
                e.Use();
            }

            var parent = reactor.hotNode.nodeParent as IParentNode;

            if (e.keyCode == KeyCode.RightArrow)
            {
                var b = reactor.hotNode as IParentNode;
                if (b != null && b.GetChildren().Length > 0)
                {
                    reactor.hotNode = b.GetChild(0);
                    e.Use();
                }
            }

            if (parent != null)
            {
                var siblings = parent.GetChildren();
                var index = System.Array.IndexOf(siblings, reactor.hotNode);
                switch (e.keyCode)
                {
                    case KeyCode.UpArrow:
                        reactor.hotNode = index - 1 < 0 ? siblings[siblings.Length - 1] : siblings[index - 1];
                        e.Use();
                        break;
                    case KeyCode.DownArrow:
                        reactor.hotNode = index + 1 >= siblings.Length ? siblings[0] : siblings[index + 1];
                        e.Use();
                        break;
                    case KeyCode.LeftArrow:
                        reactor.hotNode = reactor.hotNode.nodeParent == null ? reactor.hotNode : reactor.hotNode.nodeParent;
                        e.Use();
                        break;
                }
            }

        }

        void OnSelectionChange()
        {
            Repaint();
        }
    }

}