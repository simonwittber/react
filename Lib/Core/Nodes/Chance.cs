using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DifferentMethods.React
{

    /// <summary>
    /// Executes the child if random.value > probability. 
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Chance : DecoratorNode
    {
        public float probability = 0.5f;

        protected override NodeState Execute()
        {
            if (Child == null || Random.value > probability)
                return NodeState.Failure;
            return ExecuteNode(Child);
        }

        public static string GetMenuPath()
        {
            return "Chance _c";
        }
    }


}
