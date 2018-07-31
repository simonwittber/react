using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes method call Application.SetStackTraceLogType on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Application_SetStackTraceLogType_logType_stackTraceType : LeafNode
    {
        public UnityEngine.LogType logType;
        public UnityEngine.StackTraceLogType stackTraceType;

        
        protected override NodeState Execute() {
            UnityEngine.Application.SetStackTraceLogType(logType, stackTraceType);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Application.SetStackTraceLogType";
        public static string GetMenuPath() => "Application/Function/SetStackTraceLogType";
        public static string Signature() => " (logType,stackTraceType)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
