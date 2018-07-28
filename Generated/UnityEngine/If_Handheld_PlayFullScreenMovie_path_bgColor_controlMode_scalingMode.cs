using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Handheld.PlayFullScreenMovie on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Handheld_PlayFullScreenMovie_path_bgColor_controlMode_scalingMode : DecoratorNode
    {
        public string path;
        public UnityEngine.Color bgColor;
        public UnityEngine.FullScreenMovieControlMode controlMode;
        public UnityEngine.FullScreenMovieScalingMode scalingMode;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Handheld.PlayFullScreenMovie(path, bgColor, controlMode, scalingMode)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Handheld.PlayFullScreenMovie";
        public static string GetMenuPath() => "Handheld/If/PlayFullScreenMovie/(path, bgColor, controlMode, scalingMode)";
        public static string Signature() => " (path,bgColor,controlMode,scalingMode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
