using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_TrailRenderer_generateLightingData : LeafNode
    {
        public bool value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.generateLightingData = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<TrailRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.generateLightingData";
        public static string GetMenuPath() => "TrailRenderer/Set/generateLightingData";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
