using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DifferentMethods.React
{
    /// <summary>
    /// Jump to a label and execute the child.
    /// </summary>
	[System.Serializable]
    [CoreNode]
    public class Jump : LeafNode
    {
        public string label = "";

        protected override NodeState Execute()
        {
            return ExecuteNode(Reactor.GetLabel(label));
        }
    }
}
