using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_Rigidbody_ResetCenterOfMass_ : LeafNode
    {

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.ResetCenterOfMass();
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody.ResetCenterOfMass";
        public static string GetMenuPath() => "Rigidbody/Function/ResetCenterOfMass";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody), typeof(Function_Rigidbody_ResetCenterOfMass_));
    }
}
