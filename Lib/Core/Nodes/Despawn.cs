using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using DifferentMethods.Extensions;

namespace DifferentMethods.React
{
    public class Despawn : LeafNode
    {
        public GameObject instance;

        protected override NodeState Execute()
        {
            GameObjectPool.Return(instance);
            instance = null;
            return NodeState.Success;
        }

    }
}