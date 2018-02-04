using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DifferentMethods.React
{

    [System.Serializable]
    [CoreNode]
    public class SendMessage : LeafNode
    {
        public Reactor target;
        public string message;

        protected override NodeState Execute()
        {

            if (target == null)
                return NodeState.Continue;
            target.ReceiveMessage(message, Reactor.gameObject);
            return NodeState.Continue;
        }

    }
}
