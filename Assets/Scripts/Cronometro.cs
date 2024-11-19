using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cronometro:MonoBehaviour
{
   public float timeUntilSunrise = 480f; // Tiempo en segundos (8 minutos)
    public TextMeshProUGUI timerTextMesh; // Referencia al texto con TextMeshPro
    public Slider timerSlider; // Referencia al slider en la UI
    private bool isTimerActive = false; // Control para activar el cron�metro
    private CanvasGroup timerCanvasGroup; // Referencia al CanvasGroup dentro de timerSlider

    private float currentTimer; // Tiempo actual del cron�metro

    void Start()
    {
        // Inicializamos el slider y el cron�metro
        currentTimer = timeUntilSunrise;

        if (timerSlider != null)
        {
           
            timerSlider.maxValue = timeUntilSunrise; // Configuramos el m�ximo del slider
            timerSlider.value = timeUntilSunrise;   // Lo iniciamos lleno

            // Obtenemos el CanvasGroup dentro de timerSlider
            timerCanvasGroup = timerSlider.GetComponentInChildren<CanvasGroup>();

            if (timerCanvasGroup != null)
            {
                timerCanvasGroup.alpha = 0f; // Hacemos el cron�metro invisible al inicio
                timerCanvasGroup.interactable = false;
                timerCanvasGroup.blocksRaycasts = false;
            }
        }

        UpdateTimerUI(); // Inicializamos la UI
    }

    void Update()
    {
        if (isTimerActive && currentTimer > 0)
        {
            // Reducimos el tiempo actual
            currentTimer -= Time.deltaTime;

            // Actualizamos la UI
            UpdateTimerUI();
        }
        else if (isTimerActive && currentTimer <= 0)
        {
            // Cuando el cron�metro llega a 0
            currentTimer = 0;
            UpdateTimerUI();
            EndGame();
        }
    }

    void UpdateTimerUI()
    {
        // Formato de tiempo (minutos:segundos)
        int minutes = Mathf.FloorToInt(currentTimer / 60);
        int seconds = Mathf.FloorToInt(currentTimer % 60);

        // Actualizamos el slider
        if (timerSlider != null)
        {
            timerSlider.value = currentTimer; // El valor del slider refleja el tiempo restante
        }

        // Actualizamos el texto con TextMeshPro
        if (timerTextMesh != null)
        {
            timerTextMesh.text = $"{minutes:00}:{seconds:00}";
        }
    }

    void EndGame()
    {
        // Aqu� puedes mostrar una pantalla de victoria o finalizar la partida
        Debug.Log("�El tiempo se ha agotado!");
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verificamos si el jugador colisiona con el objeto watch
        if (other.CompareTag("Player")) // Aseg�rate de que el Player tenga asignada la etiqueta "Player"
        {
            StartTimer(); // Inicia el cron�metro al colisionar
        }
    }

    void StartTimer()
    {
        isTimerActive = true;  // Activamos el cron�metro
        currentTimer = timeUntilSunrise; // Reiniciamos el cron�metro al tiempo inicial
        if (timerSlider != null)
        {
            timerSlider.value = timeUntilSunrise; // Llenamos la barra
                                                  // Hacemos visible el cron�metro con una transici�n de alfa
            if (timerCanvasGroup != null)
            {
                StartCoroutine(FadeInCanvasGroup(timerCanvasGroup, 0.5f)); // Transici�n suave (0.5 segundos)
                timerCanvasGroup.interactable = true; // Permitimos interacci�n
                timerCanvasGroup.blocksRaycasts = true; // Habilitamos clics
            }

        }
        UpdateTimerUI(); // Actualizamos la UI
    }

    IEnumerator FadeInCanvasGroup(CanvasGroup canvasGroup, float duration)
    {
        float startAlpha = canvasGroup.alpha;
        float endAlpha = 1f;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / duration);
            yield return null;
        }

        canvasGroup.alpha = endAlpha; // Aseguramos que llegue al alfa final
    }

    IEnumerator FadeOutCanvasGroup(CanvasGroup canvasGroup, float duration)
    {
        float startAlpha = canvasGroup.alpha;
        float endAlpha = 0f;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / duration);
            yield return null;
        }

        canvasGroup.alpha = endAlpha; // Aseguramos que llegue al alfa final
    }

}
