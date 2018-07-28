using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Rigidbody.freezeRotation on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Rigidbody_freezeRotation_ : LeafNode
    {


        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            if(Component.freezeRotation) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Rigidbody.freezeRotation";
        public static string GetMenuPath() => "Rigidbody/Condition/freezeRotation";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);
    }
}
