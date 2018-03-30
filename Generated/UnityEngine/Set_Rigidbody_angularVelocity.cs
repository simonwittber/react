using DifferentMethods.React;
using UnityEngine;


namespace React.Generated
{

    /// <summary>
    /// Sets Rigidbody.angularVelocity on the active gameObject to a value. 
    /// 
    /// </summary>

    [System.Serializable]
    public class Set_Rigidbody_angularVelocity : LeafNode
    {
        public UnityEngine.Vector3 value;


        protected override NodeState Execute()
        {
            Context.gameObject.GetComponent<UnityEngine.Rigidbody>().angularVelocity = this.value;
            return NodeState.Continue;
        }

        public override string ToString()
        {
            return NiceName();
        }

        public static string NiceName()
        {
            return "SET Rigidbody.angularVelocity";
        }

        public static string GetMenuPath()
        {
            return "Rigidbody/Set/angularVelocity";
        }

        public static string Signature()
        {
            return "";
        }

        public override System.Type GetWrappedType()
        {
            return typeof(Rigidbody);
        }

    }
}
