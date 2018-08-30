using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Animator_GetBool_id : DecoratorNode
    {
        public int id;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.GetBool(id)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animator.GetBool";
        public static string GetMenuPath() => "Animator/If/GetBool/(id)";
        public static string Signature() => " (id)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }

    
    [System.Serializable]
    public class Not_If_Animator_GetBool_id : DecoratorNode
    {
        public int id;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.GetBool(id)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Animator.GetBool";
        public static string GetMenuPath() => "Animator/If/GetBool/(id)";
        public static string Signature() => " (id)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
