using UnityEngine;

public class Bullet : MonoBehaviour, IDamage
{
    [SerializeField] private float bulletDamage = 10f;

    public float ProvideDamage()
    {
        return bulletDamage;
    }
}
