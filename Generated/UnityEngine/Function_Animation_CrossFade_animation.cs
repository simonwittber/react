using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes method call Animation.CrossFade on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Animation_CrossFade_animation : LeafNode
    {
        public string animation;


        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.CrossFade(animation);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animation>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Animation.CrossFade";
        public static string GetMenuPath() => "Animation/Function/CrossFade/(animation)";
        public static string Signature() => " (animation)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Animation), typeof(Function_Animation_CrossFade_animation));

    }
}
