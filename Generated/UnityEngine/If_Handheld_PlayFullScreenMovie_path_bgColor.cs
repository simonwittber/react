using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
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

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Handheld.PlayFullScreenMovie";
        public static string GetMenuPath() => "Handheld/If/PlayFullScreenMovie/(path, bgColor)";
        public static string Signature() => " (path,bgColor)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }

    
    [System.Serializable]
    public class NotIf_Handheld_PlayFullScreenMovie_path_bgColor : DecoratorNode
    {
        public string path;
        public UnityEngine.Color bgColor;

        
        protected override NodeState Execute() 
        {
            if(!UnityEngine.Handheld.PlayFullScreenMovie(path, bgColor)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Handheld.PlayFullScreenMovie";
        public static string GetMenuPath() => "Handheld/If/PlayFullScreenMovie/(path, bgColor)";
        public static string Signature() => " (path,bgColor)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
