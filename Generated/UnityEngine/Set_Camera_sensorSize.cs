using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Camera.sensorSize on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Camera_sensorSize : LeafNode
    {
        public UnityEngine.Vector2 value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.sensorSize = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Camera>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.sensorSize";
        public static string GetMenuPath() => "Camera/Set/sensorSize";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
