using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Rigidbody.interpolation on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Rigidbody_interpolation : LeafNode
    {
        public UnityEngine.RigidbodyInterpolation value;

        protected Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.interpolation = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Rigidbody>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody.interpolation";
        public static string GetMenuPath() => "Rigidbody/Set/interpolation";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody);
    }
}
