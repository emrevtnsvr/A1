using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
  
   public static ScoreManager instance;

   public int Score { get; private set; }

   public event Action<int> OnScoreChanged;

   void Awake()
   {
     instance = this;
   }

   public void AddScore(int amount)
   {
     Score += amount;
     OnScoreChanged?.Invoke(Score);
   }
   
}
