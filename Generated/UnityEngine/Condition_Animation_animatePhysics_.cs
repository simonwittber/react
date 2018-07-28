using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Animation.animatePhysics on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Animation_animatePhysics_ : LeafNode
    {


        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() {
            if(Component.animatePhysics) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Animation>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Animation.animatePhysics";
        public static string GetMenuPath() => "Animation/Condition/animatePhysics";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);
    }
}
