using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    
    [System.Serializable]
    public class Set_Transform_hasChanged : LeafNode
    {
        public bool value;

        protected Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.hasChanged = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Transform>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Transform.hasChanged";
        public static string GetMenuPath() => "Transform/Set/hasChanged";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Transform);
    }
}
