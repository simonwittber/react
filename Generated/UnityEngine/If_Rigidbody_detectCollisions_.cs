using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Rigidbody.detectCollisions on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Rigidbody_detectCollisions_ : DecoratorNode
    {


        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.detectCollisions) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Rigidbody.detectCollisions";
        public static string GetMenuPath() => "Rigidbody/If/detectCollisions";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);

    }
}
