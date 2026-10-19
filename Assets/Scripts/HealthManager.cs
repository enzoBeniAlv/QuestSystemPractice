using UnityEngine;
public class HealthManager : MonoBehaviour
{
    [SerializeField] private Health health;

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Return)){
            health.TakeDamage(20);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            health.Heal(5);
        }
        
    }
}
