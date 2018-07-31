using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Camera.clearFlags on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Camera_clearFlags : LeafNode
    {
        public UnityEngine.CameraClearFlags value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.clearFlags = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Camera>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.clearFlags";
        public static string GetMenuPath() => "Camera/Set/clearFlags";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
