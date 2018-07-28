using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Rigidbody2D.simulated on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Rigidbody2D_simulated : LeafNode
    {
        public bool value;

        protected Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.simulated = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Rigidbody2D>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody2D.simulated";
        public static string GetMenuPath() => "Rigidbody2D/Set/simulated";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody2D);
    }
}
