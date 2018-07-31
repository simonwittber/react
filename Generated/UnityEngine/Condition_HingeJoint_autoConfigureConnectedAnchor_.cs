using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of HingeJoint.autoConfigureConnectedAnchor on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_HingeJoint_autoConfigureConnectedAnchor_ : LeafNode
    {

        protected UnityEngine.HingeJoint Component { get; set; }

        protected override NodeState Execute() {
            if(Component.autoConfigureConnectedAnchor) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.HingeJoint>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK HingeJoint.autoConfigureConnectedAnchor";
        public static string GetMenuPath() => "HingeJoint/Condition/autoConfigureConnectedAnchor";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint);
    }
}
