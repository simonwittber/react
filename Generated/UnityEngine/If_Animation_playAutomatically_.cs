using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Animation.playAutomatically on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Animation_playAutomatically_ : DecoratorNode
    {


        protected UnityEngine.Animation Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.playAutomatically) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Animation>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Animation.playAutomatically";
        public static string GetMenuPath() => "Animation/If/playAutomatically";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Animation);

    }
}
