using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DifferentMethods.React.Components;

namespace DifferentMethods.React
{
    /// <summary>
    /// This is the root parent of all nodes, and is just a container with no functional behaviour.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Root : BranchNode
    {

        public bool Dead { get; private set; }

        public IEnumerable<BaseNode> AllDescendants
        {
            get
            {
                var stack = new Stack<BaseNode>();
                stack.Push(this);
                while (stack.Count > 0)
                {
                    var current = stack.Pop();
                    yield return current;
                    var parent = current as IParentNode;
                    if (parent != null)
                        foreach (var i in parent.GetChildren())
                            stack.Push(i);
                }
            }
        }

        public override void OnAfterDeserialize(BaseNode parent, Reactor reactor)
        {
            base.OnAfterDeserialize(parent, reactor);
        }

        protected override NodeState Execute()
        {
            if (Dead)
                return NodeState.Failure;
            try
            {
                for (int i = 0, count = Children.Count; i < count; i++)
                {
                    var child = Children[i];
                    ExecuteNode(child);
                }
                return NodeState.NoResult;
            }
            catch (System.Exception)
            {
                Dead = true;
                throw;
            }
        }

        public override string ToString()
        {
            return "";
        }

    }
}