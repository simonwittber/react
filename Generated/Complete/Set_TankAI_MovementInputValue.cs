using DifferentMethods.React;
using UnityEngine;
using Complete;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets TankAI.MovementInputValue on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_TankAI_MovementInputValue : LeafNode
    {
        public float value;

        protected TankAI Component { get; set; }

        protected override NodeState Execute() {
            Component.MovementInputValue = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<TankAI>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET TankAI.MovementInputValue";
        public static string GetMenuPath() => "TankAI/Set/MovementInputValue";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TankAI);
    }
}
