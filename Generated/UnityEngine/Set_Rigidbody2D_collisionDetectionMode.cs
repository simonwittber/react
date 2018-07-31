using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Rigidbody2D.collisionDetectionMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Rigidbody2D_collisionDetectionMode : LeafNode
    {
        public UnityEngine.CollisionDetectionMode2D value;

        protected Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.collisionDetectionMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Rigidbody2D>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody2D.collisionDetectionMode";
        public static string GetMenuPath() => "Rigidbody2D/Set/collisionDetectionMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody2D);
    }
}
