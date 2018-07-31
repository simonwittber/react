using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Physics2D.colliderAwakeColor on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics2D_colliderAwakeColor : LeafNode
    {
        public UnityEngine.Color value;

        protected override NodeState Execute() {
            Physics2D.colliderAwakeColor = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics2D.colliderAwakeColor";
        public static string GetMenuPath() => "Physics2D/Set/colliderAwakeColor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics2D);
    }
}
