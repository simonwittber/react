using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Renderer.sharedMaterial on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_sharedMaterial : LeafNode
    {
        public UnityEngine.Material value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.sharedMaterial = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Renderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.sharedMaterial";
        public static string GetMenuPath() => "Renderer/Set/sharedMaterial";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
