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
        public string id;
        public int _id { get; private set; }

        public override void OnEnable()
        {
            _id = id.GetHashCode();
        }

        protected override NodeState Execute()
        {

            if (target == null)
                return NodeState.NoResult;
            target.ReceiveMessage(_id, Reactor.gameObject);
            return NodeState.NoResult;
        }
    }
}
