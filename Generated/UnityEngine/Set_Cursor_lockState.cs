using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Cursor.lockState on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Cursor_lockState : LeafNode
    {
        public UnityEngine.CursorLockMode value;

        protected override NodeState Execute() {
            Cursor.lockState = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Cursor.lockState";
        public static string GetMenuPath() => "Cursor/Set/lockState";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Cursor);
    }
}
