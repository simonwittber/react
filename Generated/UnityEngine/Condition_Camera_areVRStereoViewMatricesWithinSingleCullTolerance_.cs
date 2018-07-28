using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    /// <summary>
    /// Returns Success or Failure depending on result of Camera.areVRStereoViewMatricesWithinSingleCullTolerance on the active gameObject.
    /// </summary>
    
    [System.Serializable]
    public class Condition_Camera_areVRStereoViewMatricesWithinSingleCullTolerance_ : LeafNode
    {


        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() {
            if(Component.areVRStereoViewMatricesWithinSingleCullTolerance) 
                return NodeState.Success;
            return NodeState.Failure;
        }

        public override void OnEnable() {
            base.OnEnable();
            
            Component = gameObject.GetComponent<UnityEngine.Camera>();
        }

        public override string ToString() => NiceName();
        public static string NiceName() => "CHECK Camera.areVRStereoViewMatricesWithinSingleCullTolerance";
        public static string GetMenuPath() => "Camera/Condition/areVRStereoViewMatricesWithinSingleCullTolerance";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }
}
