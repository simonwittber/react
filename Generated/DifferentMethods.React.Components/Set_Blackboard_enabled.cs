using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Blackboard_enabled : LeafNode
    {
        public bool value;

        protected Blackboard Component { get; set; }

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Blackboard>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Blackboard.enabled";
        public static string GetMenuPath() => "Blackboard/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Blackboard);
    }
}
