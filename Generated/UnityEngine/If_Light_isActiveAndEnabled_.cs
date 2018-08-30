using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Light_isActiveAndEnabled_ : DecoratorNode
    {

        protected UnityEngine.Light Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Light>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Light.isActiveAndEnabled";
        public static string GetMenuPath() => "Light/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Light);
    }

    
    [System.Serializable]
    public class Not_If_Light_isActiveAndEnabled_ : DecoratorNode
    {

        protected UnityEngine.Light Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.isActiveAndEnabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Light>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Light.isActiveAndEnabled";
        public static string GetMenuPath() => "Light/If/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Light);
    }
}
