using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_SpriteRenderer_motionVectorGenerationMode : LeafNode
    {
        public UnityEngine.MotionVectorGenerationMode value;

        protected SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            Component.motionVectorGenerationMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<SpriteRenderer>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET SpriteRenderer.motionVectorGenerationMode";
        public static string GetMenuPath() => "SpriteRenderer/Set/motionVectorGenerationMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(SpriteRenderer);
    }
}
