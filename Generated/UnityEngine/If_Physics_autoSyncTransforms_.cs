using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Physics.autoSyncTransforms on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics_autoSyncTransforms_ : DecoratorNode
    {

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.autoSyncTransforms) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.autoSyncTransforms";
        public static string GetMenuPath() => "Physics/If/autoSyncTransforms";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
