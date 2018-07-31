using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Animation.animatePhysics on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Animation_animatePhysics : LeafNode
    {
        public bool value;

        protected Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.animatePhysics = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Animation>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animation.animatePhysics";
        public static string GetMenuPath() => "Animation/Set/animatePhysics";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animation);
    }
}
