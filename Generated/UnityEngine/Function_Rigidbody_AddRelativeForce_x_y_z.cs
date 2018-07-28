using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Rigidbody.AddRelativeForce on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Rigidbody_AddRelativeForce_x_y_z : LeafNode
    {
        public float x;
        public float y;
        public float z;


        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.AddRelativeForce(x, y, z);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody.AddRelativeForce";
        public static string GetMenuPath() => "Rigidbody/Function/AddRelativeForce/(x, y, z)";
        public static string Signature() => " (x,y,z)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody), typeof(Function_Rigidbody_AddRelativeForce_x_y_z));

    }
}
