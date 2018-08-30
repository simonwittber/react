using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Collider_isTrigger_ : LeafNode
    {

        protected UnityEngine.Collider Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isTrigger) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Collider.isTrigger";
        public static string GetMenuPath() => "Collider/Condition/isTrigger";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider);
    }

    
    [System.Serializable]
    public class Not_Condition_Collider_isTrigger_ : LeafNode
    {

        protected UnityEngine.Collider Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.isTrigger) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Collider.isTrigger";
        public static string GetMenuPath() => "Collider/Condition/isTrigger";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider);
    }
}
