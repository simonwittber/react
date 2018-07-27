using System.Collections;
using System.Collections.Generic;
using DifferentMethods.Extensions;
using UnityEngine;

namespace DifferentMethods.React
{

    /// <summary>
    /// Changes the current context to use a gameObject or gameObject array referenced from the scene. If many is true, then a gameObject array is used.
    /// The target field specified the name of the variable in the component.
    /// </summary>
    [System.Serializable]
    [CoreNode]
    public class Spawn : LeafNode
    {

        public GameObject prefab;
        public float lifetime = 1;
        public bool matchPosition = true;
        public bool matchRotation = true;

        GameObject target;

        protected override NodeState Execute()
        {
            if (prefab == null)
                return NodeState.NoResult;
            target = GameObjectPool.Take(prefab, lifetime: lifetime);
            if (matchPosition)
                target.transform.position = Context.gameObject.transform.position;
            if (matchRotation)
                target.transform.rotation = Context.gameObject.transform.rotation;
            return NodeState.Success;
        }

        public static string GetMenuPath()
        {
            return "Spawn";
        }
    }


}
