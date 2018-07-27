using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    /// <summary>
    /// Log a message to the console.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Log : LeafNode
    {
        public string msg = "";

        protected override NodeState Execute()
        {
            Debug.Log($"<color=yellow><b>REACT:</b> {msg}</color>");
            return NodeState.NoResult;
        }
    }


}
