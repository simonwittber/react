using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets TrailRenderer.minVertexDistance on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_TrailRenderer_minVertexDistance : LeafNode
    {
        public float value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.minVertexDistance = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<TrailRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.minVertexDistance";
        public static string GetMenuPath() => "TrailRenderer/Set/minVertexDistance";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
