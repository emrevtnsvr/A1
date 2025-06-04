using TMPro;
using UnityEngine;

public class CoinTextUI : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;

    private void Start()
    {
        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.OnScoreChanged -= UpdateCoinText;
            ScoreManager.instance.OnScoreChanged += UpdateCoinText;
            UpdateCoinText(ScoreManager.instance.Score);
        }
    }

    private void OnEnable()
    {
        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.OnScoreChanged += UpdateCoinText;
        }
    }

    private void OnDisable()
    {
        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.OnScoreChanged -= UpdateCoinText;
        }
    }

    private void UpdateCoinText(int score)
    {
        coinText.text = "Coin: " + score;
    }
}