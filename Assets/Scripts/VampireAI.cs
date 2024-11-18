using UnityEngine;

public class VampireAI : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public float speed = 3f; // Velocidad de movimiento
    public float retreatTime = 0f; // Tiempo restante de alejamiento

    private Vector3 originalPosition; // Posici�n inicial del vampiro

    void Start()
    {
        // Guardar posici�n inicial
        originalPosition = transform.position;
    }

    void Update()
    {
        // Si est� "asustado", retrocede
        if (retreatTime > 0)
        {
            retreatTime -= Time.deltaTime;
            RetreatFromPlayer();
            return;
        }

        // Verifica si el jugador est� en rango
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        ChasePlayer();

    }

    // Perseguir al jugador
    void ChasePlayer()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
        transform.LookAt(player); // Rotar hacia el jugador
    }

    // Retroceder (al ser "asustado" por un objeto)
    void RetreatFromPlayer()
    {
        Vector3 direction = (transform.position - player.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

    // Volver a la posici�n inicial si no est� persiguiendo
    void ReturnToStart()
    {
        if (Vector3.Distance(transform.position, originalPosition) > 0.1f)
        {
            Vector3 direction = (originalPosition - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
            transform.LookAt(originalPosition);
        }
    }

    // M�todo p�blico para asustar al vampiro
    public void Scare(float duration)
    {
        retreatTime = duration;
    }
}
