using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DifferentMethods.React
{

    [System.Serializable]
    [CoreNode]
    public class WaitForAnimatorSignal : LeafNode, IReceiveAnimatorSignal
    {
        public Animator animator;
        public string signal = "";
        bool signalReceived = false;

        public override void OnEnable()
        {
            base.OnEnable();
            if (animator == null) animator = Reactor.GetComponent<Animator>();
            if (animator != null)
                SendSignal.Register(animator, signal, this);
        }

        protected override NodeState Execute()
        {
            if (animator != null)
            {
                if (signalReceived)
                    return NodeState.Success;
                return NodeState.Continue;
            }
            return NodeState.Failure;

        }
        public void OnSignal(string name, bool value)
        {
            this.signalReceived = value;
        }
    }
}
