using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of HingeJoint2D.useLimits on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_HingeJoint2D_useLimits_ : LeafNode
    {


        protected UnityEngine.HingeJoint2D Component { get; set; }

        protected override NodeState Execute() {
            if(Component.useLimits) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.HingeJoint2D>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK HingeJoint2D.useLimits";
        public static string GetMenuPath() => "HingeJoint2D/Condition/useLimits";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint2D);
    }
}
