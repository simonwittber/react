using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Rigidbody.solverVelocityIterations on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Rigidbody_solverVelocityIterations : LeafNode
    {
        public int value;

        protected Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.solverVelocityIterations = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Rigidbody>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody.solverVelocityIterations";
        public static string GetMenuPath() => "Rigidbody/Set/solverVelocityIterations";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody);
    }
}