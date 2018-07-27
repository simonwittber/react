using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    /// <summary>
    /// Execute it's child if the current gameObject tag is a match.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class CompareTag : DecoratorNode
    {
        public string tag;

        protected override NodeState Execute()
        {
            if (Child != null)
            {
                if (Context.gameObject.CompareTag(tag))
                {
                    return ExecuteNode(Child);
                }
            }
            return NodeState.NoResult;
        }

        public override string ToString()
        {
            return "TagIs";
        }

    }
}
