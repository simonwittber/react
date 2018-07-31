using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Physics.gravity on the class to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Physics_gravity : LeafNode
    {
        public UnityEngine.Vector3 value;

        protected override NodeState Execute() {
            Physics.gravity = this.value;
            return NodeState.NoResult;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "SET Physics.gravity";
        public static string GetMenuPath() => "Physics/Set/gravity";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Physics);
    }
}
