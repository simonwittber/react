using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Debug_DrawLine_start_end : LeafNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;

        
        protected override NodeState Execute() {
            UnityEngine.Debug.DrawLine(start, end);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Debug.DrawLine";
        public static string GetMenuPath() => "Debug/Function/DrawLine/(start, end)";
        public static string Signature() => " (start,end)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Debug);
    }
}
