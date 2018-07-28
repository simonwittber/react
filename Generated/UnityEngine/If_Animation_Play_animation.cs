using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Animation.Play on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Animation_Play_animation : DecoratorNode
    {
        public string animation;


        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.Play(animation)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animation>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animation.Play";
        public static string GetMenuPath() => "Animation/If/Play/(animation)";
        public static string Signature() => " (animation)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);

    }
}
