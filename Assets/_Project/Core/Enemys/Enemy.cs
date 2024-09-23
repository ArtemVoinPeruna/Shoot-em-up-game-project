using UnityEngine;
using UnityEngine.AI;

namespace Core.Enemys
{
    public class Enemy : MonoBehaviour
    {
        [field: SerializeField] private NavMeshAgent _agent;
        private GameObject targetObject;

        private void Awake() 
        {

            targetObject = GameObject.FindWithTag("Player");

            _agent.updateRotation = false;
		    _agent.updateUpAxis = false;
        }

        private void Update() 
        {
            _agent.SetDestination(targetObject.transform.position);
            if (_agent.remainingDistance <= _agent.stoppingDistance)
            {
                Debug.Log("Я бью!");
            }
        }
    }
}
