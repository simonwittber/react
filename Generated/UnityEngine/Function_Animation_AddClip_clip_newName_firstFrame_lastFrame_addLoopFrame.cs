using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animation.AddClip on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animation_AddClip_clip_newName_firstFrame_lastFrame_addLoopFrame : LeafNode
    {
        public UnityEngine.AnimationClip clip;
        public string newName;
        public int firstFrame;
        public int lastFrame;
        public bool addLoopFrame;


        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.AddClip(clip, newName, firstFrame, lastFrame, addLoopFrame);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animation>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animation.AddClip";
        public static string GetMenuPath() => "Animation/Function/AddClip/(clip, newName, firstFrame, lastFrame, addLoopFrame)";
        public static string Signature() => " (clip,newName,firstFrame,lastFrame,addLoopFrame)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animation), typeof(Function_Animation_AddClip_clip_newName_firstFrame_lastFrame_addLoopFrame));

    }
}
