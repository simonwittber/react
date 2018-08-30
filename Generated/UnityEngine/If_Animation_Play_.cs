using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Animation_Play_ : DecoratorNode
    {

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.Play()) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animation.Play";
        public static string GetMenuPath() => "Animation/If/Play";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }

    
    [System.Serializable]
    public class Not_If_Animation_Play_ : DecoratorNode
    {

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.Play()) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Animation.Play";
        public static string GetMenuPath() => "Animation/If/Play";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }
}
