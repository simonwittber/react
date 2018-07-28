using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Physics2D.alwaysShowColliders on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Physics2D_alwaysShowColliders_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Physics2D.alwaysShowColliders)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Physics2D.alwaysShowColliders";
        public static string GetMenuPath() => "Physics2D/Condition/alwaysShowColliders";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
