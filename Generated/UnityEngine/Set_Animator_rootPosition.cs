using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Animator.rootPosition on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Animator_rootPosition : LeafNode
    {
        public UnityEngine.Vector3 value;

        protected Animator Component { get; set; }

        protected override NodeState Execute() {
            Component.rootPosition = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Animator>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animator.rootPosition";
        public static string GetMenuPath() => "Animator/Set/rootPosition";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animator);
    }
}
