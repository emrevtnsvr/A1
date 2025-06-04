using System;
using UnityEngine;



public class HealthController : MonoBehaviour
{
    [SerializeField] private float fullHealth;

    private float _health;

    // health update event

    public event Action<float , float , float > OnHealthUpdated; // damage taken , full health , current health

    void Start()
    {
        _health = fullHealth;
    }

    public void GetDamage(float damage)
    {
        _health -= damage;
        Debug.Log("Health after damage: " + _health); // <- is this printing?

        OnHealthUpdated?.Invoke(damage, fullHealth, _health);
    }

    private void OnTriggerEnter(Collider other)
    {
        IDamage damager = other.GetComponent<IDamage>();
        if (damager != null)
        {
            float damage = damager.ProvideDamage();
            GetDamage(damage);
            Destroy(other.gameObject); // optional: destroy bullet
        }
    }
}
