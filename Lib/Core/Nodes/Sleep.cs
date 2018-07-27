using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DifferentMethods.React
{

    [System.Serializable]
    [CoreNode]
    public class Sleep : LeafNode
    {
        public float seconds = 1;
        float timer = -1;

        public override void Abort()
        {
            timer = -1;
        }

        protected override NodeState Execute()
        {
            if (timer < 0)
            {
                timer = seconds;
            }
            timer -= Time.deltaTime;
            if (timer > 0)
            {
                return NodeState.ContinueNextFrame;
            }
            return NodeState.NoResult;
        }

    }
}
