using UnityEngine;

namespace DifferentMethods.React
{
    [System.Serializable]
    [CoreNode]
    public class GraftPoint : DecoratorNode
    {
        public string id = "";

        protected override NodeState Execute()
        {
            if (Child != null)
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override string ToString()
        {
            return "Graft";
        }
    }

}
