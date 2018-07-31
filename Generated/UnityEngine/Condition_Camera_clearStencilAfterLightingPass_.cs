using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Camera.clearStencilAfterLightingPass on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Camera_clearStencilAfterLightingPass_ : LeafNode
    {

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            if(Component.clearStencilAfterLightingPass) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Camera.clearStencilAfterLightingPass";
        public static string GetMenuPath() => "Camera/Condition/clearStencilAfterLightingPass";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }
}
