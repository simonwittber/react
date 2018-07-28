using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Camera.useJitteredProjectionMatrixForTransparentRendering on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Camera_useJitteredProjectionMatrixForTransparentRendering_ : DecoratorNode
    {


        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.useJitteredProjectionMatrixForTransparentRendering) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Camera>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Camera.useJitteredProjectionMatrixForTransparentRendering";
        public static string GetMenuPath() => "Camera/If/useJitteredProjectionMatrixForTransparentRendering";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);

    }
}
