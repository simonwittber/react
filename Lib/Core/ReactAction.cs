
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    public class StopAction : YieldInstruction
    {

    }

    public class ReactAction : IEnumerator, System.IDisposable
    {
        public static readonly StopAction Stop = new StopAction();

        YieldInstruction current;
        bool isDone = false;
        bool reset = true;

        public object Current
        {
            get
            {
                return current;
            }
        }

        public void Dispose()
        {
            Reset();
        }

        protected virtual YieldInstruction OnContinue()
        {
            return null;
        }

        protected virtual void OnStart()
        {

        }

        protected virtual void OnFinish()
        {
            ActionPool.Recycle(this);
        }

        public bool MoveNext()
        {
            if (isDone)
                return false;
            if (reset)
            {
                reset = false;
                OnStart();
            }
            current = OnContinue();
            if (current is StopAction)
            {
                OnFinish();
                isDone = true;
                return false;
            }
            return true;
        }

        public void Reset()
        {
            if (!isDone)
            {
                OnFinish();
            }
            isDone = false;
        }
    }
}