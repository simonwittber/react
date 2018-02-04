using System.Collections.Generic;
using DifferentMethods.Extensions.Serialization;
using UnityEngine;

namespace DifferentMethods.React
{
    [System.Serializable]
    [CoreDecorator]
    public class SuperNode : DecoratorNode
    {
        public string id = "";

        public override void OnAfterDeserialize(BaseNode parent, Reactor reactor)
        {
            base.OnAfterDeserialize(parent, reactor);
            if (Child != null)
                reactor.RegisterExport(this);
        }

        public IEnumerable<GraftPoint> ParameterNodes
        {
            get
            {
                var stack = new Stack<BaseNode>();
                stack.Push(this);
                while (stack.Count > 0)
                {
                    var current = stack.Pop();
                    if (current is GraftPoint)
                        yield return current as GraftPoint;
                    if (current is SuperCall)
                        continue;
                    var parent = current as IParentNode;
                    if (parent != null)
                        foreach (var i in parent.GetChildren())
                            stack.Push(i);
                }
            }
        }

        protected override NodeState Execute()
        {
            if (Child != null)
                return ExecuteNode(Child);
            return NodeState.Continue;
        }

    }

}
