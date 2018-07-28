using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Transform.IsChildOf on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Transform_IsChildOf_parent : DecoratorNode
    {
        public UnityEngine.Transform parent;


        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.IsChildOf(parent)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Transform>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Transform.IsChildOf";
        public static string GetMenuPath() => "Transform/If/IsChildOf";
        public static string Signature() => " (parent)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);

    }
}
