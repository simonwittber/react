using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Transform.SetParent on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Transform_SetParent_parent_worldPositionStays : LeafNode
    {
        public UnityEngine.Transform parent;
        public bool worldPositionStays;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.SetParent(parent, worldPositionStays);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.SetParent";
        public static string GetMenuPath() => "Transform/Function/SetParent/(parent, worldPositionStays)";
        public static string Signature() => " (parent,worldPositionStays)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_SetParent_parent_worldPositionStays));
    }
}
