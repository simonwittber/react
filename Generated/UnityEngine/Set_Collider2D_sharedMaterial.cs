using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Collider2D.sharedMaterial on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Collider2D_sharedMaterial : LeafNode
    {
        public UnityEngine.PhysicsMaterial2D value;

        protected Collider2D Component { get; set; }

        protected override NodeState Execute() {
            Component.sharedMaterial = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Collider2D>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Collider2D.sharedMaterial";
        public static string GetMenuPath() => "Collider2D/Set/sharedMaterial";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Collider2D);
    }
}