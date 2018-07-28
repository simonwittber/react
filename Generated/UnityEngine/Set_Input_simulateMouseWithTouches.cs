using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Input.simulateMouseWithTouches on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Input_simulateMouseWithTouches : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Input.simulateMouseWithTouches = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Input.simulateMouseWithTouches";
        public static string GetMenuPath() => "Input/Set/simulateMouseWithTouches";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Input);
    }
}
