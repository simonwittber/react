using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Application.targetFrameRate on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Application_targetFrameRate : LeafNode
    {
        public int value;

        protected override NodeState Execute() {
            Application.targetFrameRate = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Application.targetFrameRate";
        public static string GetMenuPath() => "Application/Set/targetFrameRate";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Application);
    }
}
