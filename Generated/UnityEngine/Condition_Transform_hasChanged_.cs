using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Transform.hasChanged on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Transform_hasChanged_ : LeafNode
    {


        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            if(Component.hasChanged) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Transform>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Transform.hasChanged";
        public static string GetMenuPath() => "Transform/Condition/hasChanged";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);
    }
}
