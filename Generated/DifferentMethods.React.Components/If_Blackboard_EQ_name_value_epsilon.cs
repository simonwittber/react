using DifferentMethods.React;
using UnityEngine;
using DifferentMethods.React.Components;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Blackboard_EQ_name_value_epsilon : DecoratorNode
    {
        public string id;
        public float value;
        public float epsilon;

        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.EQ(id, value, epsilon)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Blackboard.EQ";
        public static string GetMenuPath() => "Blackboard/If/EQ";
        public static string Signature() => " (name,value,epsilon)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);
    }

    
    [System.Serializable]
    public class Not_If_Blackboard_EQ_name_value_epsilon : DecoratorNode
    {
        public string id;
        public float value;
        public float epsilon;

        protected DifferentMethods.React.Components.Blackboard Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.EQ(id, value, epsilon)) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<DifferentMethods.React.Components.Blackboard>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Blackboard.EQ";
        public static string GetMenuPath() => "Blackboard/If/EQ";
        public static string Signature() => " (name,value,epsilon)";
        public override System.Type GetWrappedType() => typeof(DifferentMethods.React.Components.Blackboard);
    }
}
