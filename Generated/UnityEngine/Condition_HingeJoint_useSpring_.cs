using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of HingeJoint.useSpring on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_HingeJoint_useSpring_ : LeafNode
    {


        protected UnityEngine.HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            if(Component.useSpring) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.HingeJoint>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK HingeJoint.useSpring";
        public static string GetMenuPath() => "HingeJoint/Condition/useSpring";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint);
    }
}
