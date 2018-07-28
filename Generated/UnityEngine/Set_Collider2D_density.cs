using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Collider2D.density on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Collider2D_density : LeafNode
    {
        public float value;

        protected Collider2D Component { get; set; }

        protected override NodeState Execute() {
            Component.density = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Collider2D>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Collider2D.density";
        public static string GetMenuPath() => "Collider2D/Set/density";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Collider2D);
    }
}
