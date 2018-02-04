using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DifferentMethods.React
{

    [System.Serializable]
    public class DecoratorNode : BaseNode, IParentNode
    {
        public BaseNode Child = null;

        public override int ChildCount { get { return Child == null ? 0 : 1; } }

        public void SetChild(BaseNode node)
        {
            Child = node;
        }

        public override void OnAfterDeserialize(BaseNode parent, Reactor reactor)
        {
            base.OnAfterDeserialize(parent, reactor);
            if (Child != null) Child.OnAfterDeserialize(this, reactor);
        }

        public override void OnReadyToConfigure()
        {
            base.OnReadyToConfigure();
            if (Child != null) Child.OnReadyToConfigure();
        }

        public override void Abort()
        {
            base.Abort();
            if (Child != null)
                Child.Abort();
        }

        public BaseNode[] GetChildren()
        {
            if (Child == null)
                return new BaseNode[] { };
            return new BaseNode[] { Child };
        }

        public int IndexOf(BaseNode node)
        {
            if (node == Child)
                return 0;
            return -1;
        }

        public BaseNode GetChild(int index)
        {
            if (index == 0 && Child != null)
                return Child;
            throw new IndexOutOfRangeException();
        }

        public void Clear()
        {
            Child = null;
        }

        public void Remove(BaseNode node)
        {
            if (node == Child)
                Child = null;
        }

        public void Add(BaseNode node)
        {
            Child = node;
        }

        public void Insert(int index, BaseNode node)
        {
            if (index == 0 || index == 1)
                Child = node;
            else
                throw new IndexOutOfRangeException();
        }

    }

}
