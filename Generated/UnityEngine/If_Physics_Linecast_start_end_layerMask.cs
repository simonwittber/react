using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {

    /// <summary>
    /// Executes child if result of Physics.Linecast on the class is true.
    /// </summary>
    
    [System.Serializable]
    public class If_Physics_Linecast_start_end_layerMask : DecoratorNode
    {
        public UnityEngine.Vector3 start;
        public UnityEngine.Vector3 end;
        public int layerMask;

        
        protected override NodeState Execute() 
        {
            if(UnityEngine.Physics.Linecast(start, end, layerMask)) {
                return ExecuteNode(Child);
            }
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "IF Physics.Linecast";
        public static string GetMenuPath() => "Physics/If/Linecast/(start, end, layerMask)";
        public static string Signature() => " (start,end,layerMask)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Physics);
    }
}
