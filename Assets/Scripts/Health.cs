
using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action<float, float> OnHealthChanged;
    public event Action OnDeath;

    [SerializeField] private float maxHealth = 100f;
    private float currentHealth;

    public float MaxHealth => maxHealth;
    public float CurrentHealth => currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        if(currentHealth <= 0) {
            Die();
        }
        OnHealthChanged?.Invoke(currentHealth, maxHealth);

    }

    public void Heal(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }

    public void Die(){
        OnDeath?.Invoke();
    }
}