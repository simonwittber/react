using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Renderer.receiveShadows on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_receiveShadows : LeafNode
    {
        public bool value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.receiveShadows = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Renderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.receiveShadows";
        public static string GetMenuPath() => "Renderer/Set/receiveShadows";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
