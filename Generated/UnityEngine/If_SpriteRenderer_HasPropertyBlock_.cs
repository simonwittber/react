using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of SpriteRenderer.HasPropertyBlock on the active gameObject is true.
    /// </summary>
    
    [System.Serializable]
    public class If_SpriteRenderer_HasPropertyBlock_ : DecoratorNode
    {


        protected UnityEngine.SpriteRenderer Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.HasPropertyBlock()) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.SpriteRenderer>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF SpriteRenderer.HasPropertyBlock";
        public static string GetMenuPath() => "SpriteRenderer/If/HasPropertyBlock";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.SpriteRenderer);

    }
}
