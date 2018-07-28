using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Executes method call Rigidbody.MovePosition on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Rigidbody_MovePosition_position : LeafNode
    {
        public UnityEngine.Vector3 position;


        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.MovePosition(position);
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody.MovePosition";
        public static string GetMenuPath() => "Rigidbody/Function/MovePosition";
        public static string Signature() => " (position)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody), typeof(Function_Rigidbody_MovePosition_position));

    }
}
