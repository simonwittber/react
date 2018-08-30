using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Target_enabled : LeafNode
    {
        public bool value;

        protected Target Component { get; set; }

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Target>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Target.enabled";
        public static string GetMenuPath() => "Target/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Target);
    }
}
