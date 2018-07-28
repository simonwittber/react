using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Animation.IsPlaying on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Animation_IsPlaying_name : DecoratorNode
    {
        public string id;


        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.IsPlaying(id)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animation>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animation.IsPlaying";
        public static string GetMenuPath() => "Animation/If/IsPlaying";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);

    }
}
