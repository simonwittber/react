using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of TrailRenderer.isPartOfStaticBatch on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_TrailRenderer_isPartOfStaticBatch_ : LeafNode
    {


        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isPartOfStaticBatch) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK TrailRenderer.isPartOfStaticBatch";
        public static string GetMenuPath() => "TrailRenderer/Condition/isPartOfStaticBatch";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);
    }
}
