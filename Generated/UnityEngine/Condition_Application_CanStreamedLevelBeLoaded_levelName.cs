using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Application_CanStreamedLevelBeLoaded_levelName : LeafNode
    {
        public string levelName;

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.CanStreamedLevelBeLoaded(levelName))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.CanStreamedLevelBeLoaded";
        public static string GetMenuPath() => "Application/Condition/CanStreamedLevelBeLoaded/(levelName)";
        public static string Signature() => " (levelName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }

    
    [System.Serializable]
    public class Not_Condition_Application_CanStreamedLevelBeLoaded_levelName : LeafNode
    {
        public string levelName;

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.CanStreamedLevelBeLoaded(levelName))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Application.CanStreamedLevelBeLoaded";
        public static string GetMenuPath() => "Application/Condition/CanStreamedLevelBeLoaded/(levelName)";
        public static string Signature() => " (levelName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
