using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Physics2D.colliderContactColor on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics2D_colliderContactColor : LeafNode
    {
        public UnityEngine.Color value;

        protected override NodeState Execute() {
            Physics2D.colliderContactColor = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.colliderContactColor";
        public static string GetMenuPath() => "Physics2D/Set/colliderContactColor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
