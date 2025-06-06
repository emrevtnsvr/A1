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
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
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
       
        if (OnScoreChanged != null)
        {
            Debug.Log("Calling OnScoreChanged...");
            OnScoreChanged.Invoke(Score);
        }
       
        if (Score >= totalCoins)
        {
            gameOverUI.GameFinish();
        }

    }
   
}
