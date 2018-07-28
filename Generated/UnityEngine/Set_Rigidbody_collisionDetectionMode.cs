using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Rigidbody.collisionDetectionMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Rigidbody_collisionDetectionMode : LeafNode
    {
        public UnityEngine.CollisionDetectionMode value;

        protected Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.collisionDetectionMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Rigidbody>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody.collisionDetectionMode";
        public static string GetMenuPath() => "Rigidbody/Set/collisionDetectionMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody);
    }
}
