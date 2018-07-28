using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Collider.material on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Collider_material : LeafNode
    {
        public UnityEngine.PhysicMaterial value;

        protected Collider Component { get; set; }

        protected override NodeState Execute() {
            Component.material = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Collider>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Collider.material";
        public static string GetMenuPath() => "Collider/Set/material";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Collider);
    }
}
