using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Physics.interCollisionSettingsToggle on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics_interCollisionSettingsToggle_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.interCollisionSettingsToggle) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.interCollisionSettingsToggle";
        public static string GetMenuPath() => "Physics/If/interCollisionSettingsToggle";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
