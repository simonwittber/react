using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Handheld.PlayFullScreenMovie on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Handheld_PlayFullScreenMovie_path : LeafNode
    {
        public string path;

        
        protected override NodeState Execute() {
            if(UnityEngine.Handheld.PlayFullScreenMovie(path))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Handheld.PlayFullScreenMovie";
        public static string GetMenuPath() => "Handheld/Condition/PlayFullScreenMovie/(path)";
        public static string Signature() => " (path)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Handheld);
    }
}
