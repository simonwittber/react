using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{

    /// <summary>
    /// This decorator will execute it's child every frame.
    /// </summary>
    [System.Serializable]
    [CoreDecorator(1)]
    public class OnUpdate : DecoratorNode
    {
        protected override NodeState Execute()
        {

            if (Child != null)
            {
                Reactor.QueueForExecution(Child);
            }
            return NodeState.Continue;
        }
    }

}
