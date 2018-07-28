using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Blackboard.enabled on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Blackboard_enabled : LeafNode
    {
        public bool value;

        Blackboard Component;

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = Reactor.GetComponent<Blackboard>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Blackboard.enabled";
        public static string GetMenuPath() => "Blackboard/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Blackboard);
    }
}