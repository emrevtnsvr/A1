using System;
using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;

public class ToastUI : MonoBehaviour
{
    [SerializeField] private HealthController healthController;


    private void OnEnable()
    {
        if(ScoreManager.instance != null)
        {
            ScoreManager.instance.OnScoreChanged += HowManyCoinsIHave;
        }

        healthController.OnHealthUpdated += HowManyHealthsDoIHaveLeft;
    }

    private void OnDisable()
    {
        if(ScoreManager.instance != null)
        {
            ScoreManager.instance.OnScoreChanged -= HowManyCoinsIHave;
        }
        healthController.OnHealthUpdated -= HowManyHealthsDoIHaveLeft;
    }

    private void HowManyCoinsIHave(int score)
    {
        
        Debug.Log("Coins you have now: " + ScoreManager.instance.Score);
    }


   

    private void HowManyHealthsDoIHaveLeft(float damage, float fullHealth, float currentHealth)
    {
        Debug.Log("The health you have left: " + currentHealth);
    }

}
