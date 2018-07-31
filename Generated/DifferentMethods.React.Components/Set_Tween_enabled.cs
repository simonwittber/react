using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Tween.enabled on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Tween_enabled : LeafNode
    {
        public bool value;

        protected Tween Component { get; set; }

        protected override NodeState Execute() {
            Component.enabled = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Tween>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Tween.enabled";
        public static string GetMenuPath() => "Tween/Set/enabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Tween);
    }
}
