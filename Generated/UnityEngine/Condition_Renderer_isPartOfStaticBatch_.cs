using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Renderer_isPartOfStaticBatch_ : LeafNode
    {

        protected UnityEngine.Renderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isPartOfStaticBatch) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Renderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Renderer.isPartOfStaticBatch";
        public static string GetMenuPath() => "Renderer/Condition/isPartOfStaticBatch";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Renderer);
    }

    
    [System.Serializable]
    public class Not_Condition_Renderer_isPartOfStaticBatch_ : LeafNode
    {

        protected UnityEngine.Renderer Component { get; set; }

        protected override NodeState Execute() {
            if(!Component.isPartOfStaticBatch) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Renderer>();
        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Renderer.isPartOfStaticBatch";
        public static string GetMenuPath() => "Renderer/Condition/isPartOfStaticBatch";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Renderer);
    }
}
