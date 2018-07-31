using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Sets Cursor.visible on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Cursor_visible : LeafNode
    {
        public bool value;

        protected override NodeState Execute() {
            Cursor.visible = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Cursor.visible";
        public static string GetMenuPath() => "Cursor/Set/visible";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Cursor);
    }
}
