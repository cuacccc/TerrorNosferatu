using UnityEngine;
using TMPro; // Importar el namespace para TextMeshPro

public class HolyObject : MonoBehaviour
{
    [Header("Propiedades del Objeto Sagrado")]
    public string objectName; // Nombre del objeto
    public float scareDuration = 30f; // Tiempo que asusta al vampiro


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Encuentra al vampiro y lo asusta
            VampireAI vampire = FindObjectOfType<VampireAI>();
            if (vampire != null)
            {
                vampire.Scare(scareDuration);
            }

            // Mostrar la notificaci�n en el texto
            NotificationsManager.Instance.ShowNotification(
                    $"�{objectName}! <i>(El vampiro se alejar� por {scareDuration} segundos).</i>",
                    3f
                );

            // Destruir el objeto despu�s de usarlo
            Destroy(gameObject);
        }
    }

   
}
