using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Animation_IsPlaying_name : LeafNode
    {
        public string id;

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            if(Component.IsPlaying(id)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animation.IsPlaying";
        public static string GetMenuPath() => "Animation/Condition/IsPlaying";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }

    
    [System.Serializable]
    public class Not_Condition_Animation_IsPlaying_name : LeafNode
    {
        public string id;

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.IsPlaying(id)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Animation.IsPlaying";
        public static string GetMenuPath() => "Animation/Condition/IsPlaying";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }
}
