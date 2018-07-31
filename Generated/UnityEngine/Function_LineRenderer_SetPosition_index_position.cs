using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call LineRenderer.SetPosition on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_LineRenderer_SetPosition_index_position : LeafNode
    {
        public int index;
        public UnityEngine.Vector3 position;

        protected UnityEngine.LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.SetPosition(index, position);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.LineRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "LineRenderer.SetPosition";
        public static string GetMenuPath() => "LineRenderer/Function/SetPosition";
        public static string Signature() => " (index,position)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.LineRenderer);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.LineRenderer), typeof(Function_LineRenderer_SetPosition_index_position));
    }
}
