using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Renderer_material : LeafNode
    {
        public UnityEngine.Material value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.material = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Renderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.material";
        public static string GetMenuPath() => "Renderer/Set/material";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
