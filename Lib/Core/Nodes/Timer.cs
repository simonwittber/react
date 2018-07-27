using UnityEngine;

namespace DifferentMethods.React
{
    [System.Serializable]
    [CoreNode]
    public class Timer : DecoratorNode
    {
        public float maxSeconds = 1;

        float startTime = -1;

        protected override NodeState Execute()
        {
            if (Child == null)
                return NodeState.NoResult;
            if (startTime < 0)
                startTime = Time.time;
            else
            {
                if ((Time.time - startTime) >= maxSeconds)
                {
                    Child.Abort();
                    startTime = -1;
                    return NodeState.Failure;
                }
            }
            var result = ExecuteNode(Child);
            if (result == NodeState.Success)
                return result;
            else
                return NodeState.ContinueNextFrame;
        }

        public override string ToString()
        {
            return "Timer";
        }

        public static string GetMenuPath()
        {
            return "Timer";
        }
    }

}
