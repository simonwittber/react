using DifferentMethods.React;
using UnityEngine;
using UnityEngine.Rendering;


namespace React.Generated {
    /// <summary>
    /// Sets Camera.opaqueSortMode on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Camera_opaqueSortMode : LeafNode
    {
        public UnityEngine.Rendering.OpaqueSortMode value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.opaqueSortMode = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() => Component = gameObject.GetComponent<Camera>();
        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.opaqueSortMode";
        public static string GetMenuPath() => "Camera/Set/opaqueSortMode";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
