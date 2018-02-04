using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

namespace DifferentMethods.React
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class Navigation : MonoBehaviour
    {
        NavMeshAgent agent;
        Target target;

        void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
            target = GetComponent<Target>();
        }

        public void Wander(float maxDistance)
        {
            agent.SetDestination(Vector3.Scale(Random.onUnitSphere, new Vector3(1, 0, 1).normalized * maxDistance));
        }

        public void MoveTowardsActiveTarget(float speed)
        {
            if (target != null && target.activeTarget != null)
            {
                agent.speed = speed;
                agent.SetDestination(target.activeTarget.transform.position);
            }
        }

        public void MoveAwayFromActiveTarget(float speed)
        {
            if (target != null && target.activeTarget != null)
            {
                var delta = target.activeTarget.transform.position - transform.position;
                agent.speed = speed;
                agent.SetDestination(transform.position - delta);
            }
        }

    }
}