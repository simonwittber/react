using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Animation_isPlaying_ : LeafNode
    {

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isPlaying) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animation.isPlaying";
        public static string GetMenuPath() => "Animation/Condition/isPlaying";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }

    
    [System.Serializable]
    public class Not_Condition_Animation_isPlaying_ : LeafNode
    {

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.isPlaying) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Animation.isPlaying";
        public static string GetMenuPath() => "Animation/Condition/isPlaying";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }
}
