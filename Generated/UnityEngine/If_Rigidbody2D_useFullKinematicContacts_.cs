using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Rigidbody2D_useFullKinematicContacts_ : DecoratorNode
    {

        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.useFullKinematicContacts) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Rigidbody2D.useFullKinematicContacts";
        public static string GetMenuPath() => "Rigidbody2D/If/useFullKinematicContacts";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);
    }

    
    [System.Serializable]
    public class Not_If_Rigidbody2D_useFullKinematicContacts_ : DecoratorNode
    {

        protected UnityEngine.Rigidbody2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.useFullKinematicContacts) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody2D>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Rigidbody2D.useFullKinematicContacts";
        public static string GetMenuPath() => "Rigidbody2D/If/useFullKinematicContacts";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody2D);
    }
}
