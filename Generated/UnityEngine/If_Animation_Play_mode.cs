using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Animation_Play_mode : DecoratorNode
    {
        public UnityEngine.PlayMode mode;

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.Play(mode)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animation.Play";
        public static string GetMenuPath() => "Animation/If/Play/(mode)";
        public static string Signature() => " (mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }

    
    [System.Serializable]
    public class Not_If_Animation_Play_mode : DecoratorNode
    {
        public UnityEngine.PlayMode mode;

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.Play(mode)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Animation.Play";
        public static string GetMenuPath() => "Animation/If/Play/(mode)";
        public static string Signature() => " (mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }
}
