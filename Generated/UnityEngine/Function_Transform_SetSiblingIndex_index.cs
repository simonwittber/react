using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Transform.SetSiblingIndex on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Transform_SetSiblingIndex_index : LeafNode
    {
        public int index;

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.SetSiblingIndex(index);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Transform.SetSiblingIndex";
        public static string GetMenuPath() => "Transform/Function/SetSiblingIndex";
        public static string Signature() => " (index)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Transform), typeof(Function_Transform_SetSiblingIndex_index));
    }
}
