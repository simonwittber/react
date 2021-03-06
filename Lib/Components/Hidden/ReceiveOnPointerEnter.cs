using UnityEngine;
using UnityEngine.EventSystems;

namespace DifferentMethods.React.Components
{
    [RequireComponent(typeof(Reactor))]
    public class ReceiveOnPointerEnter : MonoBehaviour, IPointerEnterHandler
    {
        public Reactor reactor;
        public BaseNode node;

        public void OnPointerEnter(PointerEventData eventData)
        {
            BaseNode.ExecuteNode(node);
        }

        void Awake()
        {
            reactor = GetComponent<Reactor>();
            hideFlags = HideFlags.HideInInspector;
        }
    }
}