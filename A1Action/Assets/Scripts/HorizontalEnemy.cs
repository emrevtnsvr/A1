using UnityEngine;

public class Horizontalenemy : MonoBehaviour, IDamage
{
    [SerializeField] private float damage = 25f;

    public float ProvideDamage()
    {
       return damage;
    }
}
