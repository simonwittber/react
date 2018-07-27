using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    /// <summary>
    /// Create a named jump point in the node tree. Always executes it's child.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Label : DecoratorNode
    {
        public string id = "";

        protected override NodeState Execute()
        {
            if (Child != null)
            {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }
    }

}
