using UnityEngine;
public class HealthManager : MonoBehaviour
{
    [SerializeField] private Health health;

    void Update()
    {
        if(health.CurrentHealth <= 0) {
            health.Die();
        }

        if(Input.GetKeyDown(KeyCode.Return)){
            health.TakeDamage(20);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            health.Heal(5);
        }
        
    }
}
