using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets TrailRenderer.numCapVertices on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_TrailRenderer_numCapVertices : LeafNode
    {
        public int value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.numCapVertices = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<TrailRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.numCapVertices";
        public static string GetMenuPath() => "TrailRenderer/Set/numCapVertices";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
