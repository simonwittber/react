using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Camera.useOcclusionCulling on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Camera_useOcclusionCulling_ : DecoratorNode
    {


        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.useOcclusionCulling) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Camera>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Camera.useOcclusionCulling";
        public static string GetMenuPath() => "Camera/If/useOcclusionCulling";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);

    }
}
