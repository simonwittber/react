using System.Reflection;
using System.Linq;

namespace DifferentMethods.React
{
    /// <summary>
    /// Information about a MethodInfo instance.
    /// </summary>
    [System.Serializable]
    public class SerializedMethodInfo
    {
        public string className;
        public string type;
        public string name;
        public string[] parameterTypeNames;
        public string niceName;
        public string returnType;

        public MethodInfo GetMethodInfo()
        {
            var componentType = System.Type.GetType(type);
            if (componentType == null) return null;
            var mi = componentType.GetMethod(name, (from i in parameterTypeNames select System.Type.GetType(i)).ToArray());
            return mi;
        }

    }
}