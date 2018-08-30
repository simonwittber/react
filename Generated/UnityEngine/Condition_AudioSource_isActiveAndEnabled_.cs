using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_AudioSource_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK AudioSource.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioSource/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }

    
    [System.Serializable]
    public class Not_Condition_AudioSource_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT AudioSource.isActiveAndEnabled";
        public static string GetMenuPath() => "AudioSource/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }
}
