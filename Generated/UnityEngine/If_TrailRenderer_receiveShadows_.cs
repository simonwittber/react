using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_TrailRenderer_receiveShadows_ : DecoratorNode
    {

        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.receiveShadows) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF TrailRenderer.receiveShadows";
        public static string GetMenuPath() => "TrailRenderer/If/receiveShadows";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);
    }

    
    [System.Serializable]
    public class Not_If_TrailRenderer_receiveShadows_ : DecoratorNode
    {

        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.receiveShadows) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT TrailRenderer.receiveShadows";
        public static string GetMenuPath() => "TrailRenderer/If/receiveShadows";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);
    }
}
