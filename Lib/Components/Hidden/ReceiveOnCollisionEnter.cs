﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    [RequireComponent(typeof(Reactor))]
    public class ReceiveOnCollisionEnter : MonoBehaviour
    {
        public Reactor reactor;
        public BaseNode node;

        void Awake()
        {
            reactor = GetComponent<Reactor>();
            hideFlags = HideFlags.HideInInspector;
        }

        void OnCollisionEnter(Collision collision)
        {
            node.Context.Update(gameObject, collision);
            BaseNode.ExecuteNode(node);
        }
    }
}