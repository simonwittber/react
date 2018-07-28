using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Physics.CheckCapsule on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics_CheckCapsule_start_end_radius_layerMask : DecoratorNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public float radius;
        public int layerMask;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.CheckCapsule(start, end, radius, layerMask)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.CheckCapsule";
        public static string GetMenuPath() => "Physics/If/CheckCapsule/(start, end, radius, layerMask)";
        public static string Signature() => " (start,end,radius,layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
