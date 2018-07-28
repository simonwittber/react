using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Animation.isPlaying on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Animation_isPlaying_ : LeafNode
    {


        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            if(Component.isPlaying) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Animation>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animation.isPlaying";
        public static string GetMenuPath() => "Animation/Condition/isPlaying";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }
}
