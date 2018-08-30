using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_LineRenderer_receiveShadows_ : LeafNode
    {

        protected UnityEngine.LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.receiveShadows) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.LineRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK LineRenderer.receiveShadows";
        public static string GetMenuPath() => "LineRenderer/Condition/receiveShadows";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.LineRenderer);
    }

    
    [System.Serializable]
    public class Not_Condition_LineRenderer_receiveShadows_ : LeafNode
    {

        protected UnityEngine.LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.receiveShadows) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.LineRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT LineRenderer.receiveShadows";
        public static string GetMenuPath() => "LineRenderer/Condition/receiveShadows";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.LineRenderer);
    }
}
