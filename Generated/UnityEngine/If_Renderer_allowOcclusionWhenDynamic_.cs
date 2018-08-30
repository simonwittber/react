using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Renderer_allowOcclusionWhenDynamic_ : DecoratorNode
    {

        protected UnityEngine.Renderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.allowOcclusionWhenDynamic) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Renderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Renderer.allowOcclusionWhenDynamic";
        public static string GetMenuPath() => "Renderer/If/allowOcclusionWhenDynamic";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Renderer);
    }

    
    [System.Serializable]
    public class Not_If_Renderer_allowOcclusionWhenDynamic_ : DecoratorNode
    {

        protected UnityEngine.Renderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.allowOcclusionWhenDynamic) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Renderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Renderer.allowOcclusionWhenDynamic";
        public static string GetMenuPath() => "Renderer/If/allowOcclusionWhenDynamic";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Renderer);
    }
}
