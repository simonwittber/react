using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Animator.runtimeAnimatorController on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Animator_runtimeAnimatorController : LeafNode
    {
        public UnityEngine.RuntimeAnimatorController value;

        protected Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.runtimeAnimatorController = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Animator>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animator.runtimeAnimatorController";
        public static string GetMenuPath() => "Animator/Set/runtimeAnimatorController";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animator);
    }
}
