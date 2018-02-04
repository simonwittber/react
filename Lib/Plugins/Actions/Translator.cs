using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace DifferentMethods.React
{
    public class Translator : ReactAction
    {

        public Transform tx;
        public Vector3 target = Vector3.zero;
        public AnimationCurve curve = null;
        public float duration = 1f;

        Vector3 start;
        float t = 0f;

        protected override void OnStart()
        {
            t = 0f;
            start = tx.position;
        }

        protected override YieldInstruction OnContinue()
        {
            t += Time.deltaTime / duration;
            if (t < 1f)
            {
                if (curve == null)
                    tx.position = Vector3.Lerp(start, target, Mathf.SmoothStep(0, 1, t));
                else
                    tx.position = Vector3.Lerp(start, target, curve.Evaluate(t));
                return null;
            }
            tx.position = target;
            curve = null;
            return ReactAction.Stop;
        }

        protected override void OnFinish()
        {
            tx.position = target;
        }

    }
}