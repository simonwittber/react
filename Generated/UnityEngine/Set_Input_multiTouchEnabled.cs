using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Input_multiTouchEnabled : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Input.multiTouchEnabled = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Input.multiTouchEnabled";
        public static string GetMenuPath() => "Input/Set/multiTouchEnabled";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Input);
    }
}
