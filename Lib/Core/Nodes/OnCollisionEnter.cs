using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    /// <summary>
    /// This decorator will execute it's child when the OnCollisionEnter message is received, if the layer mask matches the triggering gameObject.
    /// </summary>
    [System.Serializable]
    [CoreDecorator(5)]
    public class OnCollisionEnter : DecoratorNode
    {

        protected override NodeState Execute()
        {
            if (Child != null)
                Reactor.QueueForExecution(Child);
            return NodeState.NoResult;
        }
    }


}
