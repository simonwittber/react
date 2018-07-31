using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Cursor.visible on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Cursor_visible_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Cursor.visible) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Cursor.visible";
        public static string GetMenuPath() => "Cursor/If/visible";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Cursor);
    }
}
