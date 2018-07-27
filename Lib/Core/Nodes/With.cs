using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{

    [System.Serializable]
    [CoreNode]
    public class With : ContextNode
    {
        public GameObject target;

        protected override NodeState Execute()
        {
            if (Child == null || target == null)
                return NodeState.NoResult;
            SetActiveGameObject(target);
            return ExecuteNode(Child);
        }

        public static string GetMenuPath()
        {
            return "With _w";
        }
    }

}
