using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    [System.Serializable]
    
    public class Function_PlayerPrefs_Save_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.PlayerPrefs.Save();
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "PlayerPrefs.Save";
        public static string GetMenuPath() => "PlayerPrefs/Function/Save";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.PlayerPrefs);
    }
}
