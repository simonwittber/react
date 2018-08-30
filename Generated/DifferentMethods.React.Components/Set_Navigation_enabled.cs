using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Navigation_enabled : LeafNode
    {
        public bool value;

        protected Navigation Component { get; set; }

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Navigation>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Navigation.enabled";
        public static string GetMenuPath() => "Navigation/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Navigation);
    }
}
