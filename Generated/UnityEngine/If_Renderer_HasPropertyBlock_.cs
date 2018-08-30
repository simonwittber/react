using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Renderer_HasPropertyBlock_ : DecoratorNode
    {

        protected UnityEngine.Renderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.HasPropertyBlock()) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Renderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Renderer.HasPropertyBlock";
        public static string GetMenuPath() => "Renderer/If/HasPropertyBlock";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Renderer);
    }

    
    [System.Serializable]
    public class Not_If_Renderer_HasPropertyBlock_ : DecoratorNode
    {

        protected UnityEngine.Renderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.HasPropertyBlock()) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Renderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Renderer.HasPropertyBlock";
        public static string GetMenuPath() => "Renderer/If/HasPropertyBlock";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Renderer);
    }
}
