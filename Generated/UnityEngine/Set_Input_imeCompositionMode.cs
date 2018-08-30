using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Input_imeCompositionMode : LeafNode
    {
        public UnityEngine.IMECompositionMode value;

        protected override NodeState Execute() {
            Input.imeCompositionMode = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Input.imeCompositionMode";
        public static string GetMenuPath() => "Input/Set/imeCompositionMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Input);
    }
}
