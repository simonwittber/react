using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Handheld.PlayFullScreenMovie on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Handheld_PlayFullScreenMovie_path_bgColor_controlMode : DecoratorNode
    {
        public string path;
        public UnityEngine.Color bgColor;
        public UnityEngine.FullScreenMovieControlMode controlMode;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Handheld.PlayFullScreenMovie(path, bgColor, controlMode)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Handheld.PlayFullScreenMovie";
        public static string GetMenuPath() => "Handheld/If/PlayFullScreenMovie/(path, bgColor, controlMode)";
        public static string Signature() => " (path,bgColor,controlMode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
