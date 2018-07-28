using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Renderer.probeAnchor on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_probeAnchor : LeafNode
    {
        public UnityEngine.Transform value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.probeAnchor = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Renderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.probeAnchor";
        public static string GetMenuPath() => "Renderer/Set/probeAnchor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
