using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Renderer.lightmapIndex on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_lightmapIndex : LeafNode
    {
        public int value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.lightmapIndex = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Renderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.lightmapIndex";
        public static string GetMenuPath() => "Renderer/Set/lightmapIndex";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
