using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Linq;

namespace DifferentMethods.React
{
    /// <summary>
    /// A branch node has many children.
    /// </summary>
    [System.Serializable]
    public class BranchNode : BaseNode, IParentNode
    {
        public List<BaseNode> Children = new List<BaseNode>();

        public override int ChildCount { get { return Children.Count; } }

        int activeChild = 0;
        protected BaseNode ActiveChild { get { return Children.Count > 0 ? Children[activeChild] : null; } }

        public override void OnAfterDeserialize(BaseNode parent, Reactor reactor)
        {
            base.OnAfterDeserialize(parent, reactor);
            var children = new List<BaseNode>();
            foreach (var c in Children)
            {
                if (c != null)
                {
                    children.Add(c);
                    c.OnAfterDeserialize(this, reactor);
                }
            }
            Children.Clear();
            Children.AddRange(children);
        }

        public override void OnReadyToConfigure()
        {
            base.OnReadyToConfigure();
            foreach (var c in Children)
                c.OnReadyToConfigure();
        }

        public BranchNode SetChildren(params BaseNode[] children)
        {
            this.Children.Clear();
            this.Children.AddRange(children);
            return this;
        }

        public override void Abort()
        {
            base.Abort();
            ActiveChild.Abort();
            activeChild = 0;
        }

        public BaseNode[] GetChildren()
        {
            return Children.ToArray();
        }

        public void Clear()
        {
            Children.Clear();
        }

        public BaseNode GetChild(int index)
        {
            return Children[index];
        }

        public void Remove(BaseNode node)
        {
            Children.Remove(node);
        }

        public void Add(BaseNode node)
        {
            Children.Add(node);
        }

        public int IndexOf(BaseNode node)
        {
            return Children.IndexOf(node);
        }

        public void Insert(int index, BaseNode node)
        {
            if (index >= Children.Count)
            {
                Children.Add(node);
            }
            else
            {
                Children.Insert(index, node);
            }
        }

        protected bool NextChild()
        {
            activeChild++;
            if (activeChild >= Children.Count)
            {
                activeChild = 0;
                return false;
            }
            return true;
        }

    }

}
