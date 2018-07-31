using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

namespace DifferentMethods.React.Components
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
            if (agent != null)
            {
                var direction = Vector3.Slerp(-transform.right, transform.right, Random.value);
                var destination = transform.position + (direction * maxDistance);
                agent.SetDestination(destination);
            }
        }

        public bool NearDestination(float threshold)
        {
            if (agent == null) return false;
            return (transform.position - agent.destination).sqrMagnitude < (threshold * threshold);
        }

        public void MoveTowardsActiveTarget(float speed)
        {
            if (agent != null)
                if (target != null && target.activeTarget != null)
                {
                    agent.speed = speed;
                    agent.SetDestination(target.activeTarget.transform.position);
                }
        }

        public void MoveAwayFromActiveTarget(float speed)
        {
            if (agent != null)
                if (target != null && target.activeTarget != null)
                {
                    var delta = target.activeTarget.transform.position - transform.position;
                    agent.speed = speed;
                    agent.SetDestination(transform.position - delta);
                }
        }

    }
}