using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of TrailRenderer.isVisible on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_TrailRenderer_isVisible_ : LeafNode
    {


        protected UnityEngine.TrailRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isVisible) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.TrailRenderer>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK TrailRenderer.isVisible";
        public static string GetMenuPath() => "TrailRenderer/Condition/isVisible";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.TrailRenderer);
    }
}
