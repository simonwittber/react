using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets TrailRenderer.sharedMaterial on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_TrailRenderer_sharedMaterial : LeafNode
    {
        public UnityEngine.Material value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.sharedMaterial = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<TrailRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.sharedMaterial";
        public static string GetMenuPath() => "TrailRenderer/Set/sharedMaterial";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}
