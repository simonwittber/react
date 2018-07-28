using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Handheld.PlayFullScreenMovie on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Handheld_PlayFullScreenMovie_path_bgColor : DecoratorNode
    {
        public string path;
        public UnityEngine.Color bgColor;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Handheld.PlayFullScreenMovie(path, bgColor)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Handheld.PlayFullScreenMovie";
        public static string GetMenuPath() => "Handheld/If/PlayFullScreenMovie/(path, bgColor)";
        public static string Signature() => " (path,bgColor)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
