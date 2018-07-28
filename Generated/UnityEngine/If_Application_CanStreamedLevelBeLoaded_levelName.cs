using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Application.CanStreamedLevelBeLoaded on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Application_CanStreamedLevelBeLoaded_levelName : DecoratorNode
    {
        public string levelName;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Application.CanStreamedLevelBeLoaded(levelName)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Application.CanStreamedLevelBeLoaded";
        public static string GetMenuPath() => "Application/If/CanStreamedLevelBeLoaded/(levelName)";
        public static string Signature() => " (levelName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Application);
    }
}
