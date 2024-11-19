using UnityEngine;
using TMPro;

public class NotificationsManager : MonoBehaviour
{
    public static NotificationsManager Instance;
    public TextMeshProUGUI notificationText; // Referencia al texto principal
    private bool isNotificationActive = false;

    // Evento para notificar cuando se limpia la notificación
    public delegate void NotificationClearedHandler();
    public event NotificationClearedHandler OnNotificationCleared;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Si hay una notificación activa y se presiona la tecla espacio, la ocultamos
        if (isNotificationActive && Input.GetKeyDown(KeyCode.Space))
        {
            ClearNotification();
        }
    }

    public void ShowNotification(string message, float duration)
    {
        if (notificationText != null)
        {
            notificationText.text = message;
            isNotificationActive = true; // Marcar que la notificación está activa

            // Si hay un tiempo de duración, ocultar la notificación después de ese tiempo
            if (duration > 0)
            {
                Invoke("ClearNotification", duration);
            }
            
        }
    }

    void ClearNotification()
    {
        if (notificationText != null)
        {
            notificationText.text = "";
            isNotificationActive = false; // Marcar que la notificación ya no está activa

            // Disparar el evento cuando se limpia la notificación
            OnNotificationCleared?.Invoke();
        }
    }
}
