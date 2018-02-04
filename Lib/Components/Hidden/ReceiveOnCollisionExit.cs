using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    [RequireComponent(typeof(Reactor))]
    public class ReceiveOnCollisionExit : MonoBehaviour
    {
        public Reactor reactor;
        public BaseNode node;

        void Awake()
        {
            reactor = GetComponent<Reactor>();
            hideFlags = HideFlags.HideInInspector;
        }

        void OnCollisionExit(Collision collision)
        {
            node.Context.Update(gameObject, collision);
            BaseNode.ExecuteNode(node);
        }
    }
}