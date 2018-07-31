using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Debug.DrawRay on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Debug_DrawRay_start_dir : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 dir;

        
        protected override NodeState Execute() {
            UnityEngine.Debug.DrawRay(start, dir);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.DrawRay";
        public static string GetMenuPath() => "Debug/Function/DrawRay/(start, dir)";
        public static string Signature() => " (start,dir)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
