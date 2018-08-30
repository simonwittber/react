using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Debug_DrawLine_start_end_color_duration_depthTest : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public UnityEngine.Color color;
        public float duration;
        public bool depthTest;

        
        protected override NodeState Execute() {
            UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.DrawLine";
        public static string GetMenuPath() => "Debug/Function/DrawLine/(start, end, color, duration, depthTest)";
        public static string Signature() => " (start,end,color,duration,depthTest)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
