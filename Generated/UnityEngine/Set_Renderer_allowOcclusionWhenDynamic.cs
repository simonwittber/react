using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Renderer.allowOcclusionWhenDynamic on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_allowOcclusionWhenDynamic : LeafNode
    {
        public bool value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.allowOcclusionWhenDynamic = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Renderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.allowOcclusionWhenDynamic";
        public static string GetMenuPath() => "Renderer/Set/allowOcclusionWhenDynamic";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
