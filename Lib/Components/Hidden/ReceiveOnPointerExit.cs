using UnityEngine;
using UnityEngine.EventSystems;

namespace DifferentMethods.React
{
    [RequireComponent(typeof(Reactor))]
    public class ReceiveOnPointerExit : MonoBehaviour, IPointerExitHandler
    {
        public Reactor reactor;
        public BaseNode node;

        public void OnPointerExit(PointerEventData eventData)
        {
            node.Context.Update(gameObject);
            BaseNode.ExecuteNode(node);
        }

        void Awake()
        {
            reactor = GetComponent<Reactor>();
            hideFlags = HideFlags.HideInInspector;
        }
    }
}