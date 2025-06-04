using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
  
   public static ScoreManager instance;

   public int Score { get; private set; }

   public event Action<int> OnScoreChanged;


   [SerializeField] private int totalCoins; 

   [SerializeField] private GameOverUI gameOverUI; 

    void Awake()
    {
      instance = this;
    }

    private void Start()
    {
      if (totalCoins <= 0)
      {
         totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
      }
            
    }
    public void AddScore(int amount)
    {
       Score += amount;
       OnScoreChanged?.Invoke(Score);

       if (Score >= totalCoins)
       {
          Debug.Log("All coins collected!");
          gameOverUI.GameFinish();
       }

    }
   
}
