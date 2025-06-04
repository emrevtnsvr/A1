using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int coinvalue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.instance.AddScore(coinvalue);
            Destroy(gameObject);
        }
    }
}
