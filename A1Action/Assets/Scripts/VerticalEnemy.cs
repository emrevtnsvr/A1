using UnityEngine;

public class VerticalEnemy : MonoBehaviour, IDamage
{
    [SerializeField] private float damage = 30f;

    public float ProvideDamage()
    {
      return damage;
    }
}
