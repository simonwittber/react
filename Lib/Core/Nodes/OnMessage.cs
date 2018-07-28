using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DifferentMethods.React
{

    /// <summary>
    /// This decorator create a named entrypoint which can be executed via a method call on the component.
    /// </summary>
    [System.Serializable]
    [CoreDecorator(8)]
    public class OnMessage : DecoratorNode
    {
        public string id;

        public override void OnEnable()
        {
            Reactor.RegisterReceiver(this);
        }

        public void Receive(GameObject sender)
        {
            BaseNode.ExecuteNode(this);
        }

        protected override NodeState Execute()
        {

            if (Child != null)
            {
                Reactor.QueueForExecution(Child);
            }
            return NodeState.NoResult;
        }
    }

}
