using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Collider.isTrigger on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Collider_isTrigger_ : DecoratorNode
    {

        protected UnityEngine.Collider Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isTrigger) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Collider.isTrigger";
        public static string GetMenuPath() => "Collider/If/isTrigger";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider);
    }
}
