using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System;
using DifferentMethods.React.Components;

namespace DifferentMethods.React.Generated
{


}

namespace DifferentMethods.React
{
    [System.Serializable]
    public class BaseNode
    {
        public Rect rect;
        [NonSerialized] public BaseNode nodeParent;
        public NodeState lastState { get; set; }
        public float lastExecuteTime { get; set; }
        [NonSerialized] public Reactor Reactor;
        [NonSerialized] internal bool inTaskQueue = false;

        [NonSerialized] ReactContext _context;
        public ReactContext Context
        {
            get
            {
                if (_context != null) return _context;
                if (nodeParent != null) return nodeParent.Context;
                return null;
            }
            set { _context = value; }
        }

        public virtual int ChildCount { get { return 0; } }

        public virtual void OnAfterDeserialize(BaseNode parent, Reactor reactor)
        {
            this.nodeParent = parent;
            if (reactor == null)
                this.Reactor = parent.Reactor;
            else
                this.Reactor = reactor;
        }

        public virtual void OnReadyToConfigure()
        {
        }

        public static BaseNode Clone(BaseNode node)
        {
            if (node == null) return null;
            var newNode = Activator.CreateInstance(node.GetType()) as BaseNode;
            foreach (var fi in ReactTypeRegister.GetFields(node))
            {
                fi.SetValue(newNode, fi.GetValue(node));
            }
            var nodeParent = node as IParentNode;
            if (nodeParent != null)
            {
                var newNodeParent = newNode as IParentNode;
                foreach (var c in nodeParent.GetChildren())
                {
                    newNodeParent.Add(Clone(c));
                }
            }
            return newNode;
        }

        public void ReplaceWith(BaseNode node)
        {
            var p = nodeParent as IParentNode;
            if (p != null)
            {
                var index = p.IndexOf(this);
                p.Insert(index, node);
                p.Remove(this);
            }
        }

        public static BaseNode CloneWithoutChildren(BaseNode node)
        {
            if (node == null) return null;
            var newNode = Activator.CreateInstance(node.GetType()) as BaseNode;
            foreach (var fi in ReactTypeRegister.GetFields(node))
                fi.SetValue(newNode, fi.GetValue(node));
            return newNode;
        }

        public virtual void OnEnable()
        {
        }

        public virtual void OnValidate()
        {
        }

        protected virtual NodeState Execute()
        {
            return NodeState.NoResult;
        }

        public override string ToString()
        {
            return GetType().Name;
        }

        public virtual void Abort()
        {
            lastState = NodeState.Aborted;
        }

        static public NodeState ExecuteNode(BaseNode node)
        {
            if (node == null)
            {
                if (Application.isEditor) Debug.LogError("Node should not be null.");
                return NodeState.NoResult;
            }
            var result = node.Execute();
            node.lastState = result;
            node.lastExecuteTime = Time.time;
            return result;
        }

        public virtual Type GetWrappedType()
        {
            return null;
        }

    }

}

