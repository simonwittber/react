using DifferentMethods.React;
using UnityEngine;
using Complete;


namespace React.Generated {

    /// <summary>
    /// Executes method call TankAI.UpdateControlValues on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_TankAI_UpdateControlValues_ : LeafNode
    {


        protected Complete.TankAI Component { get; set; }

        protected override NodeState Execute() {
            Component.UpdateControlValues();
            return NodeState.NoResult;
        }

        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Complete.TankAI>();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "TankAI.UpdateControlValues";
        public static string GetMenuPath() => "TankAI/Function/UpdateControlValues";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(Complete.TankAI);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(Complete.TankAI), typeof(Function_TankAI_UpdateControlValues_));

    }
}
