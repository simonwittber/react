using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets TrailRenderer.sortingLayerName on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_TrailRenderer_sortingLayerName : LeafNode
    {
        public string value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.sortingLayerName = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<TrailRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.sortingLayerName";
        public static string GetMenuPath() => "TrailRenderer/Set/sortingLayerName";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
