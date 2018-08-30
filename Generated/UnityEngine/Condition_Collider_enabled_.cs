using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Collider_enabled_ : LeafNode
    {

        protected UnityEngine.Collider Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Collider.enabled";
        public static string GetMenuPath() => "Collider/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider);
    }

    
    [System.Serializable]
    public class Not_Condition_Collider_enabled_ : LeafNode
    {

        protected UnityEngine.Collider Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Collider.enabled";
        public static string GetMenuPath() => "Collider/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider);
    }
}
