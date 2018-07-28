using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Physics2D.SyncTransforms on the class, then returns a NoResult state.
    /// </summary>
    [System.Serializable]
    
    public class Function_Physics2D_SyncTransforms_ : LeafNode
    {

        
        protected override NodeState Execute() {
            UnityEngine.Physics2D.SyncTransforms();
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Physics2D.SyncTransforms";
        public static string GetMenuPath() => "Physics2D/Function/SyncTransforms";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics2D);
    }
}
