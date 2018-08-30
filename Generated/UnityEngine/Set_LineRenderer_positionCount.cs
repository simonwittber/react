using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_LineRenderer_positionCount : LeafNode
    {
        public int value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.positionCount = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<LineRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.positionCount";
        public static string GetMenuPath() => "LineRenderer/Set/positionCount";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
