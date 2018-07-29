using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets TrailRenderer.motionVectorGenerationMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_TrailRenderer_motionVectorGenerationMode : LeafNode
    {
        public UnityEngine.MotionVectorGenerationMode value;

        protected TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.motionVectorGenerationMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<TrailRenderer>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET TrailRenderer.motionVectorGenerationMode";
        public static string GetMenuPath() => "TrailRenderer/Set/motionVectorGenerationMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TrailRenderer);
    }
}