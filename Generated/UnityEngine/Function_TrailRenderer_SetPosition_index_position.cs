using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Function_TrailRenderer_SetPosition_index_position : LeafNode
    {
        public int index;
        public UnityEngine.Vector3 position;

        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.SetPosition(index, position);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "TrailRenderer.SetPosition";
        public static string GetMenuPath() => "TrailRenderer/Function/SetPosition";
        public static string Signature() => " (index,position)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.TrailRenderer), typeof(Function_TrailRenderer_SetPosition_index_position));
    }
}
