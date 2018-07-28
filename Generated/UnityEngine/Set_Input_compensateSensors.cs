using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets Input.compensateSensors on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Input_compensateSensors : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Input.compensateSensors = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Input.compensateSensors";
        public static string GetMenuPath() => "Input/Set/compensateSensors";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Input);
    }
}
