using System;
using Entitys;
using UnityEngine;
using UnityEngine.AI;

namespace Core.Enemys
{
    public class Enemy : MonoBehaviour
    {
        [field: SerializeField] private NavMeshAgent _agent;

        private void Awake() 
        {

            GameObject targetObject = GameObject.FindWithTag("Player");
            
            _agent.updateRotation = false;
		    _agent.updateUpAxis = false;
            _agent.SetDestination(targetObject.transform.position);
        }

        private void Update() 
        {
            if (_agent.remainingDistance <= _agent.stoppingDistance)
            {
                Debug.Log("Я бью!");
            }
        }
    }
}
