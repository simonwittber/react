using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets LineRenderer.numCapVertices on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_LineRenderer_numCapVertices : LeafNode
    {
        public int value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.numCapVertices = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<LineRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.numCapVertices";
        public static string GetMenuPath() => "LineRenderer/Set/numCapVertices";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
