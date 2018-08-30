using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_SpriteRenderer_flipY_ : LeafNode
    {

        protected UnityEngine.SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.flipY) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.SpriteRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK SpriteRenderer.flipY";
        public static string GetMenuPath() => "SpriteRenderer/Condition/flipY";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.SpriteRenderer);
    }

    
    [System.Serializable]
    public class Not_Condition_SpriteRenderer_flipY_ : LeafNode
    {

        protected UnityEngine.SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.flipY) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.SpriteRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT SpriteRenderer.flipY";
        public static string GetMenuPath() => "SpriteRenderer/Condition/flipY";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.SpriteRenderer);
    }
}
