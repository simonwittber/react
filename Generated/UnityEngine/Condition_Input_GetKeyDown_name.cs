using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Input.GetKeyDown on the class.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Input_GetKeyDown_name : LeafNode
    {
        public string id;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetKeyDown(id))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.GetKeyDown";
        public static string GetMenuPath() => "Input/Condition/GetKeyDown/(name)";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
