using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DifferentMethods.React.Components;

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
                return NodeState.NoResult;
            target.ReceiveMessage(message, Reactor.gameObject);
            return NodeState.NoResult;
        }

    }
}
