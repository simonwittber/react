using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Animator_GetBool_id : LeafNode
    {
        public int id;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(Component.GetBool(id)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animator.GetBool";
        public static string GetMenuPath() => "Animator/Condition/GetBool/(id)";
        public static string Signature() => " (id)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }

    
    [System.Serializable]
    public class Not_Condition_Animator_GetBool_id : LeafNode
    {
        public int id;

        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.GetBool(id)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animator>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Animator.GetBool";
        public static string GetMenuPath() => "Animator/Condition/GetBool/(id)";
        public static string Signature() => " (id)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
