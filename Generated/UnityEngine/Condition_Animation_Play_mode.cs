using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Animation.Play on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Animation_Play_mode : LeafNode
    {
        public UnityEngine.PlayMode mode;


        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            if(Component.Play(mode)) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Animation>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animation.Play";
        public static string GetMenuPath() => "Animation/Condition/Play/(mode)";
        public static string Signature() => " (mode)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }
}