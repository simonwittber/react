using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Cursor.visible on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Cursor_visible_ : LeafNode
    {

        
        protected override NodeState Execute() {
            if(UnityEngine.Cursor.visible)
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Cursor.visible";
        public static string GetMenuPath() => "Cursor/Condition/visible";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Cursor);
    }
}
