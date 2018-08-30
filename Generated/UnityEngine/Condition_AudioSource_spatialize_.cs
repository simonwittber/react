using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_AudioSource_spatialize_ : LeafNode
    {

        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() {
            if(Component.spatialize) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioSource.spatialize";
        public static string GetMenuPath() => "AudioSource/Condition/spatialize";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }

    
    [System.Serializable]
    public class Not_Condition_AudioSource_spatialize_ : LeafNode
    {

        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.spatialize) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT AudioSource.spatialize";
        public static string GetMenuPath() => "AudioSource/Condition/spatialize";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }
}
