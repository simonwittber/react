using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Camera.targetTexture on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Camera_targetTexture : LeafNode
    {
        public UnityEngine.RenderTexture value;

        protected Camera Component { get; set; }

        protected override NodeState Execute() {
            Component.targetTexture = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Camera>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Camera.targetTexture";
        public static string GetMenuPath() => "Camera/Set/targetTexture";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Camera);
    }
}
