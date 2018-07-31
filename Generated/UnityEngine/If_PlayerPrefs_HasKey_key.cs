using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of PlayerPrefs.HasKey on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_PlayerPrefs_HasKey_key : DecoratorNode
    {
        public string key;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.PlayerPrefs.HasKey(key)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF PlayerPrefs.HasKey";
        public static string GetMenuPath() => "PlayerPrefs/If/HasKey";
        public static string Signature() => " (key)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.PlayerPrefs);
    }
}
