using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of TrailRenderer.HasPropertyBlock on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_TrailRenderer_HasPropertyBlock_ : LeafNode
    {


        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.HasPropertyBlock()) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK TrailRenderer.HasPropertyBlock";
        public static string GetMenuPath() => "TrailRenderer/Condition/HasPropertyBlock";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);
    }
}
