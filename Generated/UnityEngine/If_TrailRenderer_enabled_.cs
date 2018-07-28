using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of TrailRenderer.enabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_TrailRenderer_enabled_ : DecoratorNode
    {


        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF TrailRenderer.enabled";
        public static string GetMenuPath() => "TrailRenderer/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);

    }
}
