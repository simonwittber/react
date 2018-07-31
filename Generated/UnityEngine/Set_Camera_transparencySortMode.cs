using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Sets Camera.transparencySortMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Camera_transparencySortMode : LeafNode
    {
        public UnityEngine.TransparencySortMode value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.transparencySortMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Camera>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.transparencySortMode";
        public static string GetMenuPath() => "Camera/Set/transparencySortMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
