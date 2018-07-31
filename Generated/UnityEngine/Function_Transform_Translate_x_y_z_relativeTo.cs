using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Transform.Translate on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Transform_Translate_x_y_z_relativeTo : LeafNode
    {
        public float x;
        public float y;
        public float z;
        public UnityEngine.Transform relativeTo;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.Translate(x, y, z, relativeTo);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.Translate";
        public static string GetMenuPath() => "Transform/Function/Translate/(x, y, z, relativeTo)";
        public static string Signature() => " (x,y,z,relativeTo)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_Translate_x_y_z_relativeTo));
    }
}
