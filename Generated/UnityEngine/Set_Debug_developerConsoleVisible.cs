using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Debug.developerConsoleVisible on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Debug_developerConsoleVisible : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Debug.developerConsoleVisible = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Debug.developerConsoleVisible";
        public static string GetMenuPath() => "Debug/Set/developerConsoleVisible";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Debug);
    }
}
