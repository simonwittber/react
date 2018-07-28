using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Transform.localPosition on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Transform_localPosition : LeafNode
    {
        public UnityEngine.Vector3 value;

        protected Transform Component { get; set; }

        protected override NodeState Execute() {
            Component.localPosition = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Transform>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Transform.localPosition";
        public static string GetMenuPath() => "Transform/Set/localPosition";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Transform);
    }
}
