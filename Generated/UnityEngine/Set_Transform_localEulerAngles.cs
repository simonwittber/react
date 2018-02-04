using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {

    /// <summary>
    /// Sets Transform.localEulerAngles on the active gameObject to a value. 
    /// 
    /// </summary>
    
    [System.Serializable]
    public class Set_Transform_localEulerAngles : LeafNode
    {
        public UnityEngine.Vector3 value;


        protected override NodeState Execute() {
            Context.gameObject.GetComponent<UnityEngine.Transform>().localEulerAngles = this.value;
            return NodeState.Continue;
        }

        public override string ToString ()
        {
            return NiceName();
        }

        public static string NiceName() {
            return "SET Transform.localEulerAngles";
        }

        public static string GetMenuPath() {
            return "Transform/Set/localEulerAngles";
        }

        public static string Signature() {
            return "";
        }

        public override System.Type GetWrappedType()
        {
            return typeof(Transform);
        }

    }
}
