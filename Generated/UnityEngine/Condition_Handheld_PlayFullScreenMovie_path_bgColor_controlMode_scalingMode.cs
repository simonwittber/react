using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Handheld.PlayFullScreenMovie on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Handheld_PlayFullScreenMovie_path_bgColor_controlMode_scalingMode : LeafNode
    {
        public string path;
        public UnityEngine.Color bgColor;
        public UnityEngine.FullScreenMovieControlMode controlMode;
        public UnityEngine.FullScreenMovieScalingMode scalingMode;

        
        protected override NodeState Execute() {
            if(UnityEngine.Handheld.PlayFullScreenMovie(path, bgColor, controlMode, scalingMode))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Handheld.PlayFullScreenMovie";
        public static string GetMenuPath() => "Handheld/Condition/PlayFullScreenMovie/(path, bgColor, controlMode, scalingMode)";
        public static string Signature() => " (path,bgColor,controlMode,scalingMode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
