using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of LineRenderer.allowOcclusionWhenDynamic on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_LineRenderer_allowOcclusionWhenDynamic_ : LeafNode
    {


        protected UnityEngine.LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.allowOcclusionWhenDynamic) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.LineRenderer>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK LineRenderer.allowOcclusionWhenDynamic";
        public static string GetMenuPath() => "LineRenderer/Condition/allowOcclusionWhenDynamic";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.LineRenderer);
    }
}
