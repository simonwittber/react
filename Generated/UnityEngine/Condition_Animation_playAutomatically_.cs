using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Animation_playAutomatically_ : LeafNode
    {

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            if(Component.playAutomatically) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animation.playAutomatically";
        public static string GetMenuPath() => "Animation/Condition/playAutomatically";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }

    
    [System.Serializable]
    public class Not_Condition_Animation_playAutomatically_ : LeafNode
    {

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.playAutomatically) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Animation.playAutomatically";
        public static string GetMenuPath() => "Animation/Condition/playAutomatically";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }
}
