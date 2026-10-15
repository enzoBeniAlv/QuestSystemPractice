using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private Image fillImage;
    [SerializeField] private Image gameOverImage;
    

    private void Start() {
        UpdateBar(health.CurrentHealth, health.MaxHealth);
    
    } 

    private void OnEnable()
    {
       health.OnHealthChanged += UpdateBar;
       health.OnDeath += Death;
    }

    private void OnDisable()
    {
        health.OnHealthChanged -= UpdateBar;
        health.OnDeath -= Death;
    }

    private void UpdateBar(float currentHealth, float maxHealth)
    {
        fillImage.fillAmount = currentHealth / maxHealth;
        Debug.Log($"Health: {currentHealth}/{maxHealth}");
    }

    private void Death(){
        Debug.Log($"The Player died!!");
        gameOverImage.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}