using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{

    /// <summary>
    /// Changes current context to use the gameObject which sent the received message.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class WithSender : ContextNode
    {

        protected override NodeState Execute()
        {
            if (Child == null || nodeParent.Context.sender == null)
                return NodeState.NoResult;
            SetActiveGameObject(nodeParent.Context.sender);
            return ExecuteNode(Child);
        }

        public static string GetMenuPath()
        {
            return "WithSender _n";
        }
    }

}
