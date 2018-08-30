using DifferentMethods.React;
using UnityEngine;


namespace React.Generated {
    
    [System.Serializable]
    public class If_Camera_areVRStereoViewMatricesWithinSingleCullTolerance_ : DecoratorNode
    {

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() 
        {
            if(Component.areVRStereoViewMatricesWithinSingleCullTolerance) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF Camera.areVRStereoViewMatricesWithinSingleCullTolerance";
        public static string GetMenuPath() => "Camera/If/areVRStereoViewMatricesWithinSingleCullTolerance";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }

    
    [System.Serializable]
    public class Not_If_Camera_areVRStereoViewMatricesWithinSingleCullTolerance_ : DecoratorNode
    {

        protected UnityEngine.Camera Component { get; set; }

        protected override NodeState Execute() 
        {
            if(!Component.areVRStereoViewMatricesWithinSingleCullTolerance) 
                return ExecuteNode(Child);
            return NodeState.NoResult;
        }

        public override void OnEnable() => Component = gameObject.GetComponent<UnityEngine.Camera>();
        public override string ToString() => NiceName();
        public static string NiceName() => "IF NOT Camera.areVRStereoViewMatricesWithinSingleCullTolerance";
        public static string GetMenuPath() => "Camera/If/areVRStereoViewMatricesWithinSingleCullTolerance";
        public static string Signature() => " ()";
        public override System.Type GetWrappedType() => typeof(UnityEngine.Camera);
    }
}
