using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Debug.DrawLine on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Debug_DrawLine_start_end_color_duration : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public UnityEngine.Color color;
        public float duration;

        
        protected override NodeState Execute() {
            UnityEngine.Debug.DrawLine(start, end, color, duration);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.DrawLine";
        public static string GetMenuPath() => "Debug/Function/DrawLine/(start, end, color, duration)";
        public static string Signature() => " (start,end,color,duration)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
