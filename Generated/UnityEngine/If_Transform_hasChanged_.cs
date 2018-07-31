using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Transform.hasChanged on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Transform_hasChanged_ : DecoratorNode
    {

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.hasChanged) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Transform.hasChanged";
        public static string GetMenuPath() => "Transform/If/hasChanged";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);
    }
}
