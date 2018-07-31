using DifferentMethods.React;
using UnityEngine;
using System;


namespace React.Generated {
    /// <summary>
    /// Executes method call Rigidbody.AddExplosionForce on the active gameObject, then returns a NoResult state.
    /// </summary>
    
    [System.Serializable]
    public class Function_Rigidbody_AddExplosionForce_explosionForce_explosionPosition_explosionRadius_upwardsModifier : LeafNode
    {
        public float explosionForce;
        public UnityEngine.Vector3 explosionPosition;
        public float explosionRadius;
        public float upwardsModifier;

        protected UnityEngine.Rigidbody Component { get; set; }

        protected override NodeState Execute() {
            Component.AddExplosionForce(explosionForce, explosionPosition, explosionRadius, upwardsModifier);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Rigidbody>();
        public override string ToString() => NiceName();
        public static string NiceName() => "Rigidbody.AddExplosionForce";
        public static string GetMenuPath() => "Rigidbody/Function/AddExplosionForce/(explosionForce, explosionPosition, explosionRadius, upwardsModifier)";
        public static string Signature() => " (explosionForce,explosionPosition,explosionRadius,upwardsModifier)";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Rigidbody);

        public static int leafNodeId = ReactTypeRegister.RegisterNodeClass(typeof(UnityEngine.Rigidbody), typeof(Function_Rigidbody_AddExplosionForce_explosionForce_explosionPosition_explosionRadius_upwardsModifier));
    }
}
