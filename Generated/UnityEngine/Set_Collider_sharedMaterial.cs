using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Collider.sharedMaterial on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Collider_sharedMaterial : LeafNode
    {
        public UnityEngine.PhysicMaterial value;

        protected Collider Component { get; set; }

        protected override NodeState Execute() {
            Component.sharedMaterial = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Collider>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Collider.sharedMaterial";
        public static string GetMenuPath() => "Collider/Set/sharedMaterial";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Collider);
    }
}
