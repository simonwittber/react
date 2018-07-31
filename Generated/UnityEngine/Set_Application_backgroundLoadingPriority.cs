using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Application.backgroundLoadingPriority on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Application_backgroundLoadingPriority : LeafNode
    {
        public UnityEngine.ThreadPriority value;

        protected override NodeState Execute() {
            Application.backgroundLoadingPriority = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Application.backgroundLoadingPriority";
        public static string GetMenuPath() => "Application/Set/backgroundLoadingPriority";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Application);
    }
}
