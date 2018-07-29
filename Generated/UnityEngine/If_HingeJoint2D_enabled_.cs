using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of HingeJoint2D.enabled on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_HingeJoint2D_enabled_ : DecoratorNode
    {


        protected UnityEngine.HingeJoint2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.HingeJoint2D>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF HingeJoint2D.enabled";
        public static string GetMenuPath() => "HingeJoint2D/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint2D);

    }
}
