using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Physics2D_colliderAsleepColor : LeafNode
    {
        public UnityEngine.Color value;

        protected override NodeState Execute() {
            Physics2D.colliderAsleepColor = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.colliderAsleepColor";
        public static string GetMenuPath() => "Physics2D/Set/colliderAsleepColor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
