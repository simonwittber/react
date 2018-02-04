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
            return NodeState.Continue;
        }

        public override string ToString()
        {
            return "Graft";
        }
    }

}
