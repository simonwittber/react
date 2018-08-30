using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_Cursor_SetCursor_texture_hotspot_cursorMode : LeafNode
    {
        public UnityEngine.Texture2D texture;
        public UnityEngine.Vector2 hotspot;
        public UnityEngine.CursorMode cursorMode;

        
        protected override NodeState Execute() {
            UnityEngine.Cursor.SetCursor(texture, hotspot, cursorMode);
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Cursor.SetCursor";
        public static string GetMenuPath() => "Cursor/Function/SetCursor";
        public static string Signature() => " (texture,hotspot,cursorMode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Cursor);
    }
}
