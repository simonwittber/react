using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_SpriteRenderer_isPartOfStaticBatch_ : DecoratorNode
    {

        protected UnityEngine.SpriteRenderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.isPartOfStaticBatch) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.SpriteRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF SpriteRenderer.isPartOfStaticBatch";
        public static string GetMenuPath() => "SpriteRenderer/If/isPartOfStaticBatch";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.SpriteRenderer);
    }

    
    [System.Serializable]
    public class Not_If_SpriteRenderer_isPartOfStaticBatch_ : DecoratorNode
    {

        protected UnityEngine.SpriteRenderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.isPartOfStaticBatch) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.SpriteRenderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT SpriteRenderer.isPartOfStaticBatch";
        public static string GetMenuPath() => "SpriteRenderer/If/isPartOfStaticBatch";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.SpriteRenderer);
    }
}
