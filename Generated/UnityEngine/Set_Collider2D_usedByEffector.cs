using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Collider2D.usedByEffector on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Collider2D_usedByEffector : LeafNode
    {
        public bool value;

        protected Collider2D Component { get; set; }

        protected override NodeState Execute() {
            Component.usedByEffector = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Collider2D>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Collider2D.usedByEffector";
        public static string GetMenuPath() => "Collider2D/Set/usedByEffector";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Collider2D);
    }
}
