using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
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

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Rigidbody.isKinematic";
        public static string GetMenuPath() => "Rigidbody/If/isKinematic";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);
    }

    
    [System.Serializable]
    public class Not_If_Rigidbody_isKinematic_ : DecoratorNode
    {

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.isKinematic) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Rigidbody.isKinematic";
        public static string GetMenuPath() => "Rigidbody/If/isKinematic";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);
    }
}
