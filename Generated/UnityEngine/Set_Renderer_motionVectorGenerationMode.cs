using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Renderer.motionVectorGenerationMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Renderer_motionVectorGenerationMode : LeafNode
    {
        public UnityEngine.MotionVectorGenerationMode value;

        protected Renderer Component { get; set; }

        protected override NodeState Execute() {
            Component.motionVectorGenerationMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Renderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Renderer.motionVectorGenerationMode";
        public static string GetMenuPath() => "Renderer/Set/motionVectorGenerationMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Renderer);
    }
}
