using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Renderer.isVisible on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Renderer_isVisible_ : DecoratorNode
    {


        protected UnityEngine.Renderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isVisible) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Renderer>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Renderer.isVisible";
        public static string GetMenuPath() => "Renderer/If/isVisible";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Renderer);

    }
}
