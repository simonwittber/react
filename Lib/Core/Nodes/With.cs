using System.Collections;
using System.Collections.Generic;
using DifferentMethods.React.Components;
using UnityEngine;

namespace DifferentMethods.React
{

    [System.Serializable]
    [CoreNode]
    public class With : DecoratorNode
    {
        public GameObject target;

        public override void Configure(Reactor reactor, GameObject context)
        {
            //switch context to new gameObject.
            base.Configure(reactor, target);
        }

        protected override NodeState Execute()
        {
            if (Child == null || target == null)
                return NodeState.NoResult;
            return ExecuteNode(Child);
        }

        public static string GetMenuPath()
        {
            return "With _w";
        }
    }

}
