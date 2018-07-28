using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Animator.updateMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Animator_updateMode : LeafNode
    {
        public UnityEngine.AnimatorUpdateMode value;

        protected Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.updateMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Animator>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animator.updateMode";
        public static string GetMenuPath() => "Animator/Set/updateMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animator);
    }
}
