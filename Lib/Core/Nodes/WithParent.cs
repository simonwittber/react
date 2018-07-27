using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{

    /// <summary>
    /// Changes current context to use the parent gameObject.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class WithParent : ContextNode
    {

        protected override NodeState Execute()
        {
            if (Child == null)
                return NodeState.NoResult;
            SetActiveGameObject(Reactor.transform.parent.gameObject);
            return ExecuteNode(Child);
        }

        public static string GetMenuPath()
        {
            return "WithParent";
        }
    }

}
