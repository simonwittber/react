using UnityEngine;
using UnityEngine.EventSystems;

namespace DifferentMethods.React.Components
{
    [RequireComponent(typeof(Reactor))]
    public class ReceiveOnPointerExit : MonoBehaviour, IPointerExitHandler
    {
        public Reactor reactor;
        public BaseNode node;

        public void OnPointerExit(PointerEventData eventData)
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