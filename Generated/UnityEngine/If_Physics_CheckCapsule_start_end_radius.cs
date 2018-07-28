using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Physics.CheckCapsule on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics_CheckCapsule_start_end_radius : DecoratorNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public float radius;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.CheckCapsule(start, end, radius)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.CheckCapsule";
        public static string GetMenuPath() => "Physics/If/CheckCapsule/(start, end, radius)";
        public static string Signature() => " (start,end,radius)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
