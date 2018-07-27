using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace DifferentMethods.React.Components
{
    public class Rotator : ReactAction
    {

        public Transform tx;
        public Quaternion target = Quaternion.identity;
        public AnimationCurve curve = null;
        public float duration = 1f;

        Quaternion start;
        float t = 0f;

        protected override void OnStart()
        {
            t = 0f;
            start = tx.rotation;
        }

        protected override YieldInstruction OnContinue()
        {
            t += Time.deltaTime / duration;
            if (t < 1f)
            {
                if (curve == null)
                    tx.rotation = Quaternion.Slerp(start, target, Mathf.SmoothStep(0, 1, t));
                else
                    tx.rotation = Quaternion.Slerp(start, target, curve.Evaluate(t));
                return null;
            }
            tx.rotation = target;
            curve = null;
            return ReactAction.Stop;
        }

        protected override void OnFinish()
        {
            tx.rotation = target;
        }

    }
}