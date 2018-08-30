using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_HingeJoint_useMotor_ : DecoratorNode
    {

        protected UnityEngine.HingeJoint Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.useMotor) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.HingeJoint>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF HingeJoint.useMotor";
        public static string GetMenuPath() => "HingeJoint/If/useMotor";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint);
    }

    
    [System.Serializable]
    public class Not_If_HingeJoint_useMotor_ : DecoratorNode
    {

        protected UnityEngine.HingeJoint Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.useMotor) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.HingeJoint>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT HingeJoint.useMotor";
        public static string GetMenuPath() => "HingeJoint/If/useMotor";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint);
    }
}
