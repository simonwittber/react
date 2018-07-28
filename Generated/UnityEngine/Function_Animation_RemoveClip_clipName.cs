using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animation.RemoveClip on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animation_RemoveClip_clipName : LeafNode
    {
        public string clipName;


        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.RemoveClip(clipName);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animation>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animation.RemoveClip";
        public static string GetMenuPath() => "Animation/Function/RemoveClip/(clipName)";
        public static string Signature() => " (clipName)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animation), typeof(Function_Animation_RemoveClip_clipName));

    }
}
