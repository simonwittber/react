using System.Collections.Generic;
using DifferentMethods.React.Components;
using UnityEngine;

namespace DifferentMethods.React
{
    [System.Serializable]
    [CoreNode]
    public class WithMany : DecoratorNode
    {
        public GameObjectList targets = new GameObjectList();

        protected override NodeState Execute()
        {
            if (Child == null || targets.Count == 0)
                return NodeState.NoResult;
            for (var i = 0; i < targets.Count; i++)
            {
                var go = targets[i];
                if (go != null)
                {
                    Child.Configure(Reactor, go);
                    Child.OnEnable();
                    ExecuteNode(Child);
                }
            }
            return NodeState.Success;
        }

        public static string NiceName() => "With Many";
        public static string GetMenuPath() => "With Many";
    }
}
