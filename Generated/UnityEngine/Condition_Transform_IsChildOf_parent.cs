using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Transform.IsChildOf on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Transform_IsChildOf_parent : LeafNode
    {
        public UnityEngine.Transform parent;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            if(Component.IsChildOf(parent)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Transform.IsChildOf";
        public static string GetMenuPath() => "Transform/Condition/IsChildOf";
        public static string Signature() => " (parent)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);
    }
}
