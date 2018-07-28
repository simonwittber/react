using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React.Components
{
    [RequireComponent(typeof(Reactor))]
    public class ReceiveOnTriggerExit : MonoBehaviour
    {
        public Reactor reactor;
        public BaseNode node;

        void Awake()
        {
            reactor = GetComponent<Reactor>();
            hideFlags = HideFlags.HideInInspector;
        }

        void OnTriggerExit(Collider other)
        {
            BaseNode.ExecuteNode(node);
        }
    }
}