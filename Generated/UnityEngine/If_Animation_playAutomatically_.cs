using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Animation_playAutomatically_ : DecoratorNode
    {

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.playAutomatically) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animation.playAutomatically";
        public static string GetMenuPath() => "Animation/If/playAutomatically";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }

    
    [System.Serializable]
    public class Not_If_Animation_playAutomatically_ : DecoratorNode
    {

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.playAutomatically) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Animation.playAutomatically";
        public static string GetMenuPath() => "Animation/If/playAutomatically";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }
}
