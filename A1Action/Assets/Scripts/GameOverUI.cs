using UnityEngine;
using UnityEngine.UI;


public class GameOverUI : MonoBehaviour
{
    [SerializeField] HealthController healthController;

    [SerializeField] Canvas gameOverCanvas;

    void OnEnable()
    {
        healthController.OnHealthUpdated += OnGameOver;
    }

    void OnDisable()
    {
        healthController.OnHealthUpdated -= OnGameOver;
    }

    private void OnGameOver(float damage, float fullHealth, float currentHealth) 
    {
        if (healthController != null && currentHealth <= 0)
        {
            gameOverCanvas.enabled = true;
        }
    }

}
