using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    /// <summary>
    /// This decorator will execute it's child when the OnCollisionExit message is received, if the layer mask matches the triggering gameObject.
    /// </summary>
    [System.Serializable]
    [CoreDecorator(7)]
    public class OnCollisionExit : DecoratorNode
    {
        public LayerMask layers = -1;

        void Reset()
        {
            layers = LayerMask.NameToLayer("Everything");
        }

        protected override NodeState Execute()
        {

            if (Child != null && (0 != (layers.value & 1 << Context.other.gameObject.layer)))
            {
                Reactor.QueueForExecution(Child);
            }
            return NodeState.Continue;
        }
    }

}
