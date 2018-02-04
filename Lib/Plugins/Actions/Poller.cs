using UnityEngine;


namespace DifferentMethods.React
{
    public class Poller : ReactAction
    {

        public System.Action<float> fn;
        public float duration = 1f;
        float t = 0f;

        protected override void OnStart()
        {
            t = 0f;
        }

        protected override YieldInstruction OnContinue()
        {
            t += Time.deltaTime / duration;
            if (t < 1f)
            {
                fn(t);
                return null;
            }
            fn(1);
            return ReactAction.Stop;
        }

        protected override void OnFinish()
        {
            fn = null;
        }

    }
}