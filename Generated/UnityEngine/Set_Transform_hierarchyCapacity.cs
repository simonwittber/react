using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Transform_hierarchyCapacity : LeafNode
    {
        public int value;

        protected Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.hierarchyCapacity = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Transform>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Transform.hierarchyCapacity";
        public static string GetMenuPath() => "Transform/Set/hierarchyCapacity";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Transform);
    }
}
