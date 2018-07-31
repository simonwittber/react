using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Debug.DrawRay on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Debug_DrawRay_start_dir_color : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 dir;
        public UnityEngine.Color color;

        
        protected override NodeState Execute() {
            UnityEngine.Debug.DrawRay(start, dir, color);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.DrawRay";
        public static string GetMenuPath() => "Debug/Function/DrawRay/(start, dir, color)";
        public static string Signature() => " (start,dir,color)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
