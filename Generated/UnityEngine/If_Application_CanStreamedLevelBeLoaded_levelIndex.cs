using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Application_CanStreamedLevelBeLoaded_levelIndex : DecoratorNode
    {
        public int levelIndex;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Application.CanStreamedLevelBeLoaded(levelIndex)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Application.CanStreamedLevelBeLoaded";
        public static string GetMenuPath() => "Application/If/CanStreamedLevelBeLoaded/(levelIndex)";
        public static string Signature() => " (levelIndex)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }

    
    [System.Serializable]
    public class NotIf_Application_CanStreamedLevelBeLoaded_levelIndex : DecoratorNode
    {
        public int levelIndex;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Application.CanStreamedLevelBeLoaded(levelIndex)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Application.CanStreamedLevelBeLoaded";
        public static string GetMenuPath() => "Application/If/CanStreamedLevelBeLoaded/(levelIndex)";
        public static string Signature() => " (levelIndex)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
