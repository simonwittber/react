using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of LineRenderer.allowOcclusionWhenDynamic on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_LineRenderer_allowOcclusionWhenDynamic_ : DecoratorNode
    {

        protected UnityEngine.LineRenderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.allowOcclusionWhenDynamic) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.LineRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF LineRenderer.allowOcclusionWhenDynamic";
        public static string GetMenuPath() => "LineRenderer/If/allowOcclusionWhenDynamic";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.LineRenderer);
    }
}
