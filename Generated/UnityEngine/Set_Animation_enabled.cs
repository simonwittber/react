using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Animation_enabled : LeafNode
    {
        public bool value;

        protected Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Animation>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animation.enabled";
        public static string GetMenuPath() => "Animation/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animation);
    }
}
