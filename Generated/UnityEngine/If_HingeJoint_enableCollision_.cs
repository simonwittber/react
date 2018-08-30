using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_HingeJoint_enableCollision_ : DecoratorNode
    {

        protected UnityEngine.HingeJoint Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enableCollision) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.HingeJoint>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF HingeJoint.enableCollision";
        public static string GetMenuPath() => "HingeJoint/If/enableCollision";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint);
    }

    
    [System.Serializable]
    public class Not_If_HingeJoint_enableCollision_ : DecoratorNode
    {

        protected UnityEngine.HingeJoint Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.enableCollision) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.HingeJoint>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT HingeJoint.enableCollision";
        public static string GetMenuPath() => "HingeJoint/If/enableCollision";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.HingeJoint);
    }
}
