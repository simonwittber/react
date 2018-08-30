using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_AudioSource_bypassEffects_ : DecoratorNode
    {

        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.bypassEffects) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF AudioSource.bypassEffects";
        public static string GetMenuPath() => "AudioSource/If/bypassEffects";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }

    
    [System.Serializable]
    public class Not_If_AudioSource_bypassEffects_ : DecoratorNode
    {

        protected UnityEngine.AudioSource Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.bypassEffects) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.AudioSource>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT AudioSource.bypassEffects";
        public static string GetMenuPath() => "AudioSource/If/bypassEffects";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.AudioSource);
    }
}
