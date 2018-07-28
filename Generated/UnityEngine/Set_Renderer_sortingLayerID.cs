using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Renderer.sortingLayerID on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_sortingLayerID : LeafNode
    {
        public int value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.sortingLayerID = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Renderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.sortingLayerID";
        public static string GetMenuPath() => "Renderer/Set/sortingLayerID";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
