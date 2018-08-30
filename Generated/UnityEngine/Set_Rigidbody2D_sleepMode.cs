using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Rigidbody2D_sleepMode : LeafNode
    {
        public UnityEngine.RigidbodySleepMode2D value;

        protected Rigidbody2D Component { get; set; }

        protected override NodeState Execute() {
            Component.sleepMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Rigidbody2D>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody2D.sleepMode";
        public static string GetMenuPath() => "Rigidbody2D/Set/sleepMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody2D);
    }
}
