using UnityEngine;
using UnityEngine.UI;


public class GameOverUI : MonoBehaviour
{
    [SerializeField] HealthController healthController;

    [SerializeField] Canvas gameOverCanvas;

    [SerializeField] private StateManager gameStateManager;

    void OnEnable()
    {
        healthController.OnHealthUpdated += OnGameOver;
    }

    void OnDisable()
    {
        healthController.OnHealthUpdated -= OnGameOver;
    }

    public void OnGameOver(float damage, float fullHealth, float currentHealth) 
    {
        if (healthController != null && currentHealth <= 0)
        {
            gameOverCanvas.enabled = true;
            var stateManager = ServiceLocator.instance.GetService<StateManager>();
            stateManager.ChangeState(stateManager.gameOverState);
            Time.timeScale = 0f;
        }
    }

}
