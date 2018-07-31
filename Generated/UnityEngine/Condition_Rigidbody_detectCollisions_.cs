using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Rigidbody.detectCollisions on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Rigidbody_detectCollisions_ : LeafNode
    {

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            if(Component.detectCollisions) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Rigidbody.detectCollisions";
        public static string GetMenuPath() => "Rigidbody/Condition/detectCollisions";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);
    }
}
