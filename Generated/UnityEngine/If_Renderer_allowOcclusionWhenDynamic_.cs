using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Renderer.allowOcclusionWhenDynamic on the active gameObject is true.
    /// </summary>
    
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

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Renderer>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Renderer.allowOcclusionWhenDynamic";
        public static string GetMenuPath() => "Renderer/If/allowOcclusionWhenDynamic";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Renderer);

    }
}
