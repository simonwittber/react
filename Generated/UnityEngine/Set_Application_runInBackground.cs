using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Application_runInBackground : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Application.runInBackground = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Application.runInBackground";
        public static string GetMenuPath() => "Application/Set/runInBackground";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Application);
    }
}
