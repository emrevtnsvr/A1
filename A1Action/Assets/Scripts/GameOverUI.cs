using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private HealthController healthController;

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
        if (currentHealth <= 0)
        {
            var stateManager = ServiceLocator.instance.GetService<StateManager>();
            stateManager.ChangeState(stateManager.gameOverState);
        }
    }

    public void GameFinish()
    {
        var stateManager = ServiceLocator.instance.GetService<StateManager>();
        stateManager.ChangeState(stateManager.gameOverState);
    }
}