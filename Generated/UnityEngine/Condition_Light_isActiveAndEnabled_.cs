using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Light_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.Light Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Light>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Light.isActiveAndEnabled";
        public static string GetMenuPath() => "Light/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Light);
    }

    
    [System.Serializable]
    public class Not_Condition_Light_isActiveAndEnabled_ : LeafNode
    {

        protected UnityEngine.Light Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.isActiveAndEnabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Light>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Light.isActiveAndEnabled";
        public static string GetMenuPath() => "Light/Condition/isActiveAndEnabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Light);
    }
}
