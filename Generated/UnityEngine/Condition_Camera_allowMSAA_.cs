using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Camera_allowMSAA_ : LeafNode
    {

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            if(Component.allowMSAA) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Camera.allowMSAA";
        public static string GetMenuPath() => "Camera/Condition/allowMSAA";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }

    
    [System.Serializable]
    public class Not_Condition_Camera_allowMSAA_ : LeafNode
    {

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.allowMSAA) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Camera.allowMSAA";
        public static string GetMenuPath() => "Camera/Condition/allowMSAA";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }
}
