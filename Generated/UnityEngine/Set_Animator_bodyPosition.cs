using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Animator.bodyPosition on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Animator_bodyPosition : LeafNode
    {
        public UnityEngine.Vector3 value;

        protected Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.bodyPosition = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Animator>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animator.bodyPosition";
        public static string GetMenuPath() => "Animator/Set/bodyPosition";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animator);
    }
}
