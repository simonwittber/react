using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Renderer.sortingLayerName on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_sortingLayerName : LeafNode
    {
        public string value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.sortingLayerName = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Renderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.sortingLayerName";
        public static string GetMenuPath() => "Renderer/Set/sortingLayerName";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
