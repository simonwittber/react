using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DifferentMethods.React
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public class CoreDecoratorAttribute : System.Attribute
    {
        public int priority = 0;
        public CoreDecoratorAttribute(int priority = 0)
        {
            this.priority = priority;
        }
    }
}
