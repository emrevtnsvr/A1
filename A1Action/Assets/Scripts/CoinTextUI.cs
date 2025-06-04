using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinTextUI : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;

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

    private void Start()
    {
        // Show initial score
        UpdateCoinText(ScoreManager.instance.Score);
    }

    private void UpdateCoinText(int score)
    {
        coinText.text = "Coins: " + score.ToString();
    }
}
