using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
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

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Handheld.PlayFullScreenMovie";
        public static string GetMenuPath() => "Handheld/If/PlayFullScreenMovie/(path, bgColor, controlMode)";
        public static string Signature() => " (path,bgColor,controlMode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }

    
    [System.Serializable]
    public class NotIf_Handheld_PlayFullScreenMovie_path_bgColor_controlMode : DecoratorNode
    {
        public string path;
        public UnityEngine.Color bgColor;
        public UnityEngine.FullScreenMovieControlMode controlMode;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Handheld.PlayFullScreenMovie(path, bgColor, controlMode)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Handheld.PlayFullScreenMovie";
        public static string GetMenuPath() => "Handheld/If/PlayFullScreenMovie/(path, bgColor, controlMode)";
        public static string Signature() => " (path,bgColor,controlMode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
