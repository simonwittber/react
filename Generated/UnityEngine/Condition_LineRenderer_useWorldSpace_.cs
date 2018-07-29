using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of LineRenderer.useWorldSpace on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_LineRenderer_useWorldSpace_ : LeafNode
    {


        protected UnityEngine.LineRenderer Component { get; set; }

        protected override NodeState Execute() {
            if(Component.useWorldSpace) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.LineRenderer>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK LineRenderer.useWorldSpace";
        public static string GetMenuPath() => "LineRenderer/Condition/useWorldSpace";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.LineRenderer);
    }
}
