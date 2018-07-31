using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DifferentMethods.React
{
    /// <summary>
    /// Creates a named UnityEvent field in the generate component, which this node will execute.
    /// </summary>
	[System.Serializable]
    [CoreNode]
    public class TriggerUnityEvent : LeafNode
    {
        public UnityEvent ev;

        protected override NodeState Execute()
        {
            if (ev != null)
            {
                ev.Invoke();
            }
            return NodeState.NoResult;
        }

        public override string ToString() => "UnityEvent";
    }
}
