using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Animation.playAutomatically on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Animation_playAutomatically_ : LeafNode
    {


        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            if(Component.playAutomatically) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Animation>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animation.playAutomatically";
        public static string GetMenuPath() => "Animation/Condition/playAutomatically";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }
}
