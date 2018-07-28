using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Rigidbody2D.freezeRotation on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Rigidbody2D_freezeRotation_ : DecoratorNode
    {


        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.freezeRotation) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Rigidbody2D.freezeRotation";
        public static string GetMenuPath() => "Rigidbody2D/If/freezeRotation";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);

    }
}
