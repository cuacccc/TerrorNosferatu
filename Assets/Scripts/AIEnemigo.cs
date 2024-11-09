using UnityEngine;
using UnityEngine.AI;

public class AIEnemigo : MonoBehaviour
{
    public Transform player;  // arrastra el objeto del jugador a este campo en el Inspector
    public float detectionRange = 20f;  // Rango de detecci�n del jugador
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(player.position, transform.position);

        // Si el jugador est� dentro del rango de detecci�n
        if (distanceToPlayer <= detectionRange)
        {
            // Persigue al jugador
            agent.SetDestination(player.position);
        }
    }
}
