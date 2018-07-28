using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Collider2D.isTrigger on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Collider2D_isTrigger_ : LeafNode
    {


        protected UnityEngine.Collider2D Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isTrigger) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Collider2D>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Collider2D.isTrigger";
        public static string GetMenuPath() => "Collider2D/Condition/isTrigger";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Collider2D);
    }
}
