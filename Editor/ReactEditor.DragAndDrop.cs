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



namespace DifferentMethods.React.Editor
{

    public partial class ReactEditor
    {
        class DropZone
        {
            public Rect rect;
            public BaseNode parent;
            public int index;
            public bool last;

            public DropZone(BranchNode parent, Rect rect, int index, bool lastZone = false)
            {
                this.parent = parent;
                this.index = index;
                this.last = lastZone;
                if (lastZone)
                {
                    rect.y = rect.yMax - 15;
                }
                rect.height = 15;
                this.rect = rect;
            }

            public DropZone(DecoratorNode parent, Rect rect)
            {
                this.parent = parent;
                this.index = 0;
                this.last = true;
                rect.y = rect.yMax - 15;
                rect.height = 25;
                this.rect = rect;
            }
        }

        DropZone dropZone;
        List<DropZone> dropZones = new List<DropZone>();
        HashSet<BaseNode> invalidDropNodes = new HashSet<BaseNode>();

        void StartDrag()
        {
            DragAndDrop.PrepareStartDrag();
            DragAndDrop.paths = new string[] { "woot." };
            DragAndDrop.visualMode = DragAndDropVisualMode.Move;
            DragAndDrop.StartDrag(reactor.hotNode.ToString());
            dragNode = reactor.hotNode;
            invalidDropNodes.Clear();
            CollectInvalidDropNodes(dragNode);
        }

        void CollectInvalidDropNodes(BaseNode node)
        {
            var branch = node as IParentNode;
            if (branch == null)
                return;
            invalidDropNodes.Add(node);
            foreach (var child in branch.GetChildren())
            {
                CollectInvalidDropNodes(child);
            }
        }

        void UpdateDrag()
        {
            var pos = mousePosition;
            dropZone = null;
            DragAndDrop.visualMode = DragAndDropVisualMode.Rejected;
            foreach (var dz in dropZones)
            {
                var rect = dz.rect;

                if (rect.Contains(pos))
                {
                    if (invalidDropNodes.Contains(dz.parent))
                        return;
                    if (!IsValidParent(dragNode, dz.parent))
                        return;
                    dropZone = dz;
                    if (Event.current.shift)
                    {
                        DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
                    }
                    else
                    {
                        DragAndDrop.visualMode = DragAndDropVisualMode.Move;
                    }
                    DragAndDrop.AcceptDrag();
                    return;
                }
            }
        }

        void ExitDrag()
        {
            dragNode = null;
            dropZone = null;
            // reactor.hotNode = null;
        }

        void PerformDrag()
        {
            Undo.RecordObject(target, "Drag & Drop");
            var oldParent = dragNode.nodeParent as IParentNode;
            var newParent = dropZone.parent as IParentNode;
            if (ReactTypeRegister.IsCoreDecorator(dragNode.GetType()) && newParent != root)
            {
                EditorApplication.Beep();
                return;
            }
            newParent.Insert(dropZone.index, BaseNode.Clone(dragNode));
            if (!Event.current.shift)
            {
                oldParent.Remove(dragNode);
            }
            ExitDrag();
        }

        void OnGUIHasBeenDrawn()
        {
            var e = Event.current;
            if (e.type == EventType.MouseDrag && e.delta.sqrMagnitude > 1 && reactor.hotNode != null && reactor.hotNode.rect.Contains(mousePosition) && e.button == 0)
            {
                StartDrag();
                e.Use();
            }
            if (e.type == EventType.DragUpdated)
            {
                UpdateDrag();
                e.Use();
            }
            if (e.type == EventType.DragExited)
            {
                ExitDrag();
                e.Use();
            }
            if (e.type == EventType.DragPerform)
            {
                PerformDrag();
                e.Use();
            }
            if (dragNode != null)
            {
                DrawDragOutlines(dragNode);
            }

            if (dropZone != null)
            {
                if (dropZone.parent != null)
                {
                    var rect = dropZone.rect;
                    if (dropZone.last)
                        rect.y = rect.yMax;
                    else
                        rect.y -= 1;
                    rect.height = 1;
                    ReactEditorUtility.DrawOutline(dropZone.parent.rect, Color.cyan, Color.cyan / 2);
                    ReactEditorUtility.DrawOutline(rect, Color.white, Color.white / 2);
                }
            }

        }

        void DrawDragOutlines(BaseNode node)
        {
            DrawChildOutlines(node);
            var rect = dragNode.rect;
            rect.position = mousePosition;
            ReactEditorUtility.DrawOutline(rect, Color.yellow / 2, Color.yellow / 2);
        }

        void DrawChildOutlines(BaseNode node)
        {
            ReactEditorUtility.DrawOutline(node.rect, Color.yellow / 2, Color.yellow / 2);
            var p = node as IParentNode;
            if (p != null)
            {
                foreach (var c in p.GetChildren())
                {
                    DrawChildOutlines(c);
                }
            }

        }

    }

}