using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Transform.Translate on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Transform_Translate_x_y_z : LeafNode
    {
        public float x;
        public float y;
        public float z;


        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.Translate(x, y, z);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Transform>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.Translate";
        public static string GetMenuPath() => "Transform/Function/Translate/(x, y, z)";
        public static string Signature() => " (x,y,z)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_Translate_x_y_z));

    }
}
