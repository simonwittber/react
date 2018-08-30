using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_PlayerPrefs_DeleteAll_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.PlayerPrefs.DeleteAll();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "PlayerPrefs.DeleteAll";
        public static string GetMenuPath() => "PlayerPrefs/Function/DeleteAll";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.PlayerPrefs);
    }
}
