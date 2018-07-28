using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Animation.cullingType on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Animation_cullingType : LeafNode
    {
        public UnityEngine.AnimationCullingType value;

        protected Animation Component { get; set; }

        protected override NodeState Execute() {
            Component.cullingType = this.value;
            return NodeState.NoResult;
        }
        
        public override void OnEnable() {
            base.OnEnable();
            Component = gameObject.GetComponent<Animation>();
        }

        public override string ToString () => NiceName();
        public static string NiceName() => "SET Animation.cullingType";
        public static string GetMenuPath() => "Animation/Set/cullingType";
        public static string Signature() => "[SIGNATURE]";
        public override System.Type GetWrappedType() => typeof(Animation);
    }
}
