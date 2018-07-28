using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Rigidbody.inertiaTensor on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Rigidbody_inertiaTensor : LeafNode
    {
        public UnityEngine.Vector3 value;

        protected Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.inertiaTensor = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Rigidbody>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Rigidbody.inertiaTensor";
        public static string GetMenuPath() => "Rigidbody/Set/inertiaTensor";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Rigidbody);
    }
}
