using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DifferentMethods.React
{

    /// <summary>
    /// Just a document node.
    /// </summary>
	[System.Serializable]
    [CoreNode]
    public class Comment : LeafNode
    {
        public string text = "";

        protected override NodeState Execute()
        {
            return NodeState.NoResult;
        }
    }
}
