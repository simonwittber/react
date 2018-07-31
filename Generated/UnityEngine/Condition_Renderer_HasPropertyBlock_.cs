using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Renderer.HasPropertyBlock on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Renderer_HasPropertyBlock_ : LeafNode
    {

        protected UnityEngine.Renderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.HasPropertyBlock()) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Renderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Renderer.HasPropertyBlock";
        public static string GetMenuPath() => "Renderer/Condition/HasPropertyBlock";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Renderer);
    }
}
