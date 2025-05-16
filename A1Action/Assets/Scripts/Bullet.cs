using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletDamage;
    private void OnCollisionEnter(Collision collision)
    {
       var healthController = collision.gameObject.GetComponent<HealthController>();
       if (healthController != null)
        {
            healthController.GetDamage(bulletDamage);
        }
    }
}
