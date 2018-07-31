using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets LineRenderer.motionVectorGenerationMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_LineRenderer_motionVectorGenerationMode : LeafNode
    {
        public UnityEngine.MotionVectorGenerationMode value;

        protected LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.motionVectorGenerationMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<LineRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET LineRenderer.motionVectorGenerationMode";
        public static string GetMenuPath() => "LineRenderer/Set/motionVectorGenerationMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(LineRenderer);
    }
}
