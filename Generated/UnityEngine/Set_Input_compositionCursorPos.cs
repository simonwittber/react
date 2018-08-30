using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Input_compositionCursorPos : LeafNode
    {
        public UnityEngine.Vector2 value;

        protected override NodeState Execute() {
            Input.compositionCursorPos = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Input.compositionCursorPos";
        public static string GetMenuPath() => "Input/Set/compositionCursorPos";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Input);
    }
}
