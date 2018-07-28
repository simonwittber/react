using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Physics2D.colliderAABBColor on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics2D_colliderAABBColor : LeafNode
    {
        public UnityEngine.Color value;

        protected override NodeState Execute() {
            Physics2D.colliderAABBColor = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.colliderAABBColor";
        public static string GetMenuPath() => "Physics2D/Set/colliderAABBColor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
