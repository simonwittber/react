using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Debug.DrawLine on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Debug_DrawLine_start_end_color : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public UnityEngine.Color color;

        
        protected override NodeState Execute() {
            UnityEngine.Debug.DrawLine(start, end, color);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.DrawLine";
        public static string GetMenuPath() => "Debug/Function/DrawLine/(start, end, color)";
        public static string Signature() => " (start,end,color)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
