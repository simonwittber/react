using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Application.CanStreamedLevelBeLoaded on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Application_CanStreamedLevelBeLoaded_levelIndex : LeafNode
    {
        public int levelIndex;

        
        protected override NodeState Execute() {
            if(UnityEngine.Application.CanStreamedLevelBeLoaded(levelIndex))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Application.CanStreamedLevelBeLoaded";
        public static string GetMenuPath() => "Application/Condition/CanStreamedLevelBeLoaded/(levelIndex)";
        public static string Signature() => " (levelIndex)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
