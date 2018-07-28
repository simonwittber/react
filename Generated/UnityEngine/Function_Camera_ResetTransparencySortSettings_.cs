using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Camera.ResetTransparencySortSettings on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Camera_ResetTransparencySortSettings_ : LeafNode
    {


        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.ResetTransparencySortSettings();
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Camera>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Camera.ResetTransparencySortSettings";
        public static string GetMenuPath() => "Camera/Function/ResetTransparencySortSettings";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Camera), typeof(Function_Camera_ResetTransparencySortSettings_));

    }
}
