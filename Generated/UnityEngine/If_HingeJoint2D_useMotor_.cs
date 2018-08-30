using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_HingeJoint2D_useMotor_ : DecoratorNode
    {

        protected UnityEngine.HingeJoint2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.useMotor) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.HingeJoint2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF HingeJoint2D.useMotor";
        public static string GetMenuPath() => "HingeJoint2D/If/useMotor";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint2D);
    }

    
    [System.Serializable]
    public class Not_If_HingeJoint2D_useMotor_ : DecoratorNode
    {

        protected UnityEngine.HingeJoint2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.useMotor) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.HingeJoint2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT HingeJoint2D.useMotor";
        public static string GetMenuPath() => "HingeJoint2D/If/useMotor";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint2D);
    }
}
