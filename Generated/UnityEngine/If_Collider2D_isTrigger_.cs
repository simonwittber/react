using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Collider2D.isTrigger on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Collider2D_isTrigger_ : DecoratorNode
    {


        protected UnityEngine.Collider2D Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isTrigger) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Collider2D>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Collider2D.isTrigger";
        public static string GetMenuPath() => "Collider2D/If/isTrigger";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider2D);

    }
}
