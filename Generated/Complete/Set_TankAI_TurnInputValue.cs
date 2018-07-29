using DifferentMethods.React;
using UnityEngine;
using Complete;
using System;


namespace React.Generated {

    /// <summary>
    /// Sets TankAI.TurnInputValue on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_TankAI_TurnInputValue : LeafNode
    {
        public float value;

        protected TankAI Component { get; set; }

        protected override NodeState Execute() {
            Component.TurnInputValue = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<TankAI>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET TankAI.TurnInputValue";
        public static string GetMenuPath() => "TankAI/Set/TurnInputValue";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(TankAI);
    }
}
