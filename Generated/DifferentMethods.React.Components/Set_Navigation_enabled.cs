using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Navigation.enabled on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Navigation_enabled : LeafNode
    {
        public bool value;

        Navigation Component;

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<Navigation>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Navigation.enabled";
        public static string GetMenuPath() => "Navigation/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Navigation);
    }
}
