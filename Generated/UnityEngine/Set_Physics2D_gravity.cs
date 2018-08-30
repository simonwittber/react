using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Physics2D_gravity : LeafNode
    {
        public UnityEngine.Vector2 value;

        protected override NodeState Execute() {
            Physics2D.gravity = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.gravity";
        public static string GetMenuPath() => "Physics2D/Set/gravity";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
