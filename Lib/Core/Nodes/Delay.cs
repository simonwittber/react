using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


namespace DifferentMethods.React
{
    /// <summary>
    /// Asynchronously schedule the child to be executed after a delay. Always returns a continue state, and the tree will continue execution.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Delay : DecoratorNode, IComparable<Delay>
    {
        public float duration = 1f;

        protected float future = 0f;

        #region IComparable implementation

        public int CompareTo(Delay other)
        {
            return future.CompareTo(other.future);
        }

        #endregion

        public bool IsReady
        {
            get
            {
                return future <= Time.time;
            }
        }

        protected override NodeState Execute()
        {
            if (Child != null)
            {
                future = Time.time + duration;
                Reactor.DelayExecution(this);
            }
            return NodeState.NoResult;
        }

        public static string GetMenuPath()
        {
            return "Delay _d";
        }

    }
}