using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Condition_Input_GetKeyUp_name : LeafNode
    {
        public string id;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetKeyUp(id))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Input.GetKeyUp";
        public static string GetMenuPath() => "Input/Condition/GetKeyUp/(name)";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }

    
    [System.Serializable]
    public class Not_Condition_Input_GetKeyUp_name : LeafNode
    {
        public string id;

        
        protected override NodeState Execute() {
            if(UnityEngine.Input.GetKeyUp(id))
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK NOT Input.GetKeyUp";
        public static string GetMenuPath() => "Input/Condition/GetKeyUp/(name)";
        public static string Signature() => " (name)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Input);
    }
}
