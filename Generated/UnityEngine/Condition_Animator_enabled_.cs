using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Animator.enabled on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Animator_enabled_ : LeafNode
    {


        protected UnityEngine.Animator Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Animator>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animator.enabled";
        public static string GetMenuPath() => "Animator/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animator);
    }
}
