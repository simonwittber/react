using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Transform_hasChanged_ : LeafNode
    {

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            if(Component.hasChanged) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Transform.hasChanged";
        public static string GetMenuPath() => "Transform/Condition/hasChanged";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);
    }

    
    [System.Serializable]
    public class Not_Condition_Transform_hasChanged_ : LeafNode
    {

        protected UnityEngine.Transform Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.hasChanged) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Transform>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Transform.hasChanged";
        public static string GetMenuPath() => "Transform/Condition/hasChanged";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Transform);
    }
}
