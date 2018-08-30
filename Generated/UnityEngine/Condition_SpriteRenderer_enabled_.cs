using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_SpriteRenderer_enabled_ : LeafNode
    {

        protected UnityEngine.SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.SpriteRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK SpriteRenderer.enabled";
        public static string GetMenuPath() => "SpriteRenderer/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.SpriteRenderer);
    }

    
    [System.Serializable]
    public class Not_Condition_SpriteRenderer_enabled_ : LeafNode
    {

        protected UnityEngine.SpriteRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.enabled) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.SpriteRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT SpriteRenderer.enabled";
        public static string GetMenuPath() => "SpriteRenderer/Condition/enabled";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.SpriteRenderer);
    }
}
