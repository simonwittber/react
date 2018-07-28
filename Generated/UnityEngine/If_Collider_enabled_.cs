using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Collider.enabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Collider_enabled_ : DecoratorNode
    {


        protected UnityEngine.Collider Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Collider>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Collider.enabled";
        public static string GetMenuPath() => "Collider/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider);

    }
}
