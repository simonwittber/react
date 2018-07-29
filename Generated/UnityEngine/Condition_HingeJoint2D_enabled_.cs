using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of HingeJoint2D.enabled on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_HingeJoint2D_enabled_ : LeafNode
    {


        protected UnityEngine.HingeJoint2D Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.HingeJoint2D>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK HingeJoint2D.enabled";
        public static string GetMenuPath() => "HingeJoint2D/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint2D);
    }
}