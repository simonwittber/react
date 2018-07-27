using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    /// <summary>
    /// Every nodes Execute method returns this state.
    /// Continue state tells the parent to ignore the child, while the success and failure states can cause different processing in the parent.
    /// </summary>
    public enum NodeState
    {
        None,
        Success,
        Failure,
        NoResult,
        ContinueNextFrame,
        Aborted
    }

}
