using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Animation.Play on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Animation_Play_animation_mode : DecoratorNode
    {
        public string animation;
        public UnityEngine.PlayMode mode;

        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.Play(animation, mode)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Animation>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animation.Play";
        public static string GetMenuPath() => "Animation/If/Play/(animation, mode)";
        public static string Signature() => " (animation,mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }
}
