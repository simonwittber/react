using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Debug_DrawRay_start_dir_color_duration : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 dir;
        public UnityEngine.Color color;
        public float duration;

        
        protected override NodeState Execute() {
            UnityEngine.Debug.DrawRay(start, dir, color, duration);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.DrawRay";
        public static string GetMenuPath() => "Debug/Function/DrawRay/(start, dir, color, duration)";
        public static string Signature() => " (start,dir,color,duration)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
