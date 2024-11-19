using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogsController : MonoBehaviour
{
    public string[] dialogMessages; // Los mensajes a mostrar en secuencia
    private int currentDialogIndex = 0; // �ndice del mensaje actual

    private bool isNotificationActive = false;

    void Start()
    {
        // Asegurarse de que el NotificationsManager est� inicializado
        if (NotificationsManager.Instance != null)
        {
            NotificationsManager.Instance.OnNotificationCleared += ShowNextDialog; // Suscribirse al evento de limpieza
        }

        // Comienza la secuencia de di�logos
        ShowNextDialog();
    }

    // M�todo que se llama cuando la notificaci�n es destruida (evento)
    private void ShowNextDialog()
    {
        if (currentDialogIndex < dialogMessages.Length)
        {
            string message = dialogMessages[currentDialogIndex];
            NotificationsManager.Instance.ShowNotification(message, 0); // Mostrar el mensaje
            currentDialogIndex++; // Incrementar el �ndice para el siguiente mensaje
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
