using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Rigidbody2D.position on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Rigidbody2D_position : LeafNode
    {
        public UnityEngine.Vector2 value;

        protected Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.position = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Rigidbody2D>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody2D.position";
        public static string GetMenuPath() => "Rigidbody2D/Set/position";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody2D);
    }
}
