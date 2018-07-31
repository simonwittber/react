using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Executes child if result of Physics.CheckBox on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics_CheckBox_center_halfExtents : DecoratorNode
    {
        public UnityEngine.Vector3 center;
        public UnityEngine.Vector3 halfExtents;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.CheckBox(center, halfExtents)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.CheckBox";
        public static string GetMenuPath() => "Physics/If/CheckBox/(center, halfExtents)";
        public static string Signature() => " (center,halfExtents)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
