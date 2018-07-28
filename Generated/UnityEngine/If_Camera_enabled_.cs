using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Camera.enabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Camera_enabled_ : DecoratorNode
    {


        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Camera>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Camera.enabled";
        public static string GetMenuPath() => "Camera/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);

    }
}
