using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Rigidbody.isKinematic on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Rigidbody_isKinematic_ : DecoratorNode
    {


        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isKinematic) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Rigidbody.isKinematic";
        public static string GetMenuPath() => "Rigidbody/If/isKinematic";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);

    }
}
