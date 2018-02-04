using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DifferentMethods.React
{
    /// <summary>
    /// This class implements a SessionContext pattern to track which gameObject can be considered 'current' during execution of graph.
	/// It pools and re-uses context objects to prevent mallocs.
    /// </summary>
    public class ReactContext
    {
        public BaseNode owner;
        public Collider other;
        public Collision collision;
        public GameObject sender;
        public GameObject gameObject;

        ReactContext()
        {
        }

        public void Reset()
        {
            owner = null;
            other = null;
            collision = null;
            sender = null;
        }

        public static ReactContext New(BaseNode owner)
        {
            var c = new ReactContext();
            c.owner = owner;
            return c;
        }

        public void Update(GameObject go)
        {
            gameObject = go;
        }

        public void Update(GameObject go, GameObject sender)
        {
            gameObject = go;
            this.sender = sender;
        }

        public void Update(GameObject go, Collider other)
        {
            gameObject = go;
            this.other = other;
            sender = other.gameObject;
        }

        public void Update(GameObject go, Collision collision)
        {
            this.collision = collision;
            other = collision.collider;
            sender = other.gameObject;
            gameObject = go;
        }

    }

}