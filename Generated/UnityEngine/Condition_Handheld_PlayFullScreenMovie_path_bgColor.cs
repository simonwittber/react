using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Handheld_PlayFullScreenMovie_path_bgColor : LeafNode
    {
        public string path;
        public UnityEngine.Color bgColor;

        
        protected override NodeState Execute() {
            if(UnityEngine.Handheld.PlayFullScreenMovie(path, bgColor))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Handheld.PlayFullScreenMovie";
        public static string GetMenuPath() => "Handheld/Condition/PlayFullScreenMovie/(path, bgColor)";
        public static string Signature() => " (path,bgColor)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }

    
    [System.Serializable]
    public class Not_Condition_Handheld_PlayFullScreenMovie_path_bgColor : LeafNode
    {
        public string path;
        public UnityEngine.Color bgColor;

        
        protected override NodeState Execute() {
            if(UnityEngine.Handheld.PlayFullScreenMovie(path, bgColor))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Handheld.PlayFullScreenMovie";
        public static string GetMenuPath() => "Handheld/Condition/PlayFullScreenMovie/(path, bgColor)";
        public static string Signature() => " (path,bgColor)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
