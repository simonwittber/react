using UnityEngine;
using UnityEngine.EventSystems;

namespace DifferentMethods.React.Components
{
    [RequireComponent(typeof(Reactor))]
    public class ReceiveOnPointerClick : MonoBehaviour, IPointerClickHandler
    {
        public Reactor reactor;
        public BaseNode node;

        public void OnPointerClick(PointerEventData eventData)
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