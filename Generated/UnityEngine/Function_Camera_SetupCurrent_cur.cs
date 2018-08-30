using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Camera_SetupCurrent_cur : LeafNode
    {
        public UnityEngine.Camera cur;

        
        protected override NodeState Execute() {
            UnityEngine.Camera.SetupCurrent(cur);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Camera.SetupCurrent";
        public static string GetMenuPath() => "Camera/Function/SetupCurrent";
        public static string Signature() => " (cur)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }
}
