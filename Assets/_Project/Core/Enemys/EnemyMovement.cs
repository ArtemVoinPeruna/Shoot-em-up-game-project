using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    // Компоненты
    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        // Получаем компоненты
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Получаем вектор скорости агента
        Vector3 velocity = agent.velocity;
        
        // Преобразуем его в локальные координаты
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        
        // Скорость по X и Z
        float speedX = localVelocity.x;
        float speedZ = localVelocity.z;
        
        // Устанавливаем значения в Animator
        animator.SetFloat("SpeedX", speedX);
        animator.SetFloat("SpeedZ", speedZ);
    }
}