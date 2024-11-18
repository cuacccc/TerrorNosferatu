using UnityEngine;
using TMPro;

public class NotificationsManager : MonoBehaviour
{
    public static NotificationsManager Instance;

    public TextMeshProUGUI notificationText; // Referencia al texto principal

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

    public void ShowNotification(string message, float duration)
    {
        if (notificationText != null)
        {
            notificationText.text = message;
            Invoke("ClearNotification", duration);
        }
    }

    void ClearNotification()
    {
        if (notificationText != null)
        {
            notificationText.text = "";
        }
    }
}
