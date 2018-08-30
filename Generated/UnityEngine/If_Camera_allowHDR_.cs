using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Camera_allowHDR_ : DecoratorNode
    {

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.allowHDR) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Camera.allowHDR";
        public static string GetMenuPath() => "Camera/If/allowHDR";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }

    
    [System.Serializable]
    public class Not_If_Camera_allowHDR_ : DecoratorNode
    {

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.allowHDR) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Camera.allowHDR";
        public static string GetMenuPath() => "Camera/If/allowHDR";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }
}
