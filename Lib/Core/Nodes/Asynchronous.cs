using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{

    /// <summary>
    /// Schedules the child to run in the task list, always returns Continue; The node execute per frame independently of the main tree.
    /// As usual, a node will only execute over multiple frames if some of it's children return NodeState.Tick.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Asynchronous : DecoratorNode
    {
        protected override NodeState Execute()
        {
            if (Child != null)
            {
                Reactor.QueueForExecution(this.Child);
            }
            return NodeState.Continue;
        }

        public override string ToString()
        {
            return "Async";
        }

    }

}
