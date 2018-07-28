using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Animation.playAutomatically on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Animation_playAutomatically : LeafNode
    {
        public bool value;

        protected Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.playAutomatically = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Animation>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animation.playAutomatically";
        public static string GetMenuPath() => "Animation/Set/playAutomatically";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animation);
    }
}
