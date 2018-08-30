using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Collider_enabled_ : DecoratorNode
    {

        protected UnityEngine.Collider Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Collider.enabled";
        public static string GetMenuPath() => "Collider/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider);
    }

    
    [System.Serializable]
    public class Not_If_Collider_enabled_ : DecoratorNode
    {

        protected UnityEngine.Collider Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.enabled) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Collider>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Collider.enabled";
        public static string GetMenuPath() => "Collider/If/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider);
    }
}
