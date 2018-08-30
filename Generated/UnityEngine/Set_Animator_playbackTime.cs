using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Animator_playbackTime : LeafNode
    {
        public float value;

        protected Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.playbackTime = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Animator>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animator.playbackTime";
        public static string GetMenuPath() => "Animator/Set/playbackTime";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animator);
    }
}
