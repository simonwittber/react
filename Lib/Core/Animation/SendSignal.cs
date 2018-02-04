using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    /// <summary>
    /// Notify any listeners that a certain point in time has been reached while inside a state.
    /// </summary>
    public class SendSignal : StateMachineBehaviour
    {

        public string signal = "";
        [Range(0, 1)]
        public float time = 0;

        bool fired = false;
        List<IReceiveAnimatorSignal> listeners = new List<IReceiveAnimatorSignal>();

        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            fired = false;
            SetFalse();
        }

        void SetFalse()
        {
            for (var i = 0; i < listeners.Count; i++)
                listeners[i].OnSignal(signal, false);
        }

        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            SetFalse();
        }

        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (!fired && stateInfo.normalizedTime >= time)
            {
                for (var i = 0; i < listeners.Count; i++)
                    listeners[i].OnSignal(signal, true);
                fired = true;
            }

        }

        public static void Register(Animator animator, string name, IReceiveAnimatorSignal node)
        {
            var behaviours = animator.GetBehaviours<SendSignal>();
            var found = false;
            for (var i = 0; i < behaviours.Length; i++)
            {
                var s = behaviours[i];
                if (s.signal == name)
                {
                    s.listeners.Add(node);
                    found = true;
                }
            }
            if (!found)
                Debug.LogWarningFormat("Could not find a SendSignal ({0}) behaviour.", name);
        }
    }
}