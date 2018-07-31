using System.Collections;
using System.Collections.Generic;

namespace DifferentMethods.React
{

    /// <summary>
    /// Tries to executes child until a success state is received.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class UntilSuccess : DecoratorNode
    {

        protected override NodeState Execute()
        {
            if (Child == null)
                return NodeState.NoResult;
            var result = ExecuteNode(Child);
            switch (result)
            {
                case NodeState.Success:
                    return NodeState.Success;
                default:
                    return NodeState.ContinueNextFrame;
            }
        }

        public override string ToString() => "Until Success";

        public static string GetMenuPath() => "Until/Success";
    }

}
