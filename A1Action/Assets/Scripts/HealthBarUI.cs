using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    [SerializeField] private HealthController healthController;

    [SerializeField] private Image healthBarImage;

    void OnEnable()
    {
        healthController.OnHealthUpdated += UpdateHealthBarUpdated;
    }

    void OnDisable()
    {
        healthController.OnHealthUpdated -= UpdateHealthBarUpdated;
    }


    private void UpdateHealthBarUpdated(float damage , float fullHealth, float currentHealth)
    {
        healthBarImage.fillAmount = currentHealth / fullHealth;
    }
}
