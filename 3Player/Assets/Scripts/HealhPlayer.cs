using UnityEngine;
using System.Collections;

public class HealhPlayer : MonoBehaviour, IHealth {

    public delegate void HealthDepleter();
    public HealthDepleter DepleteHealth;

    [Range(0, 1)]
    public float health;

	public void DecreaseHealth(float damage)
    {
        health -= damage;

        CheckDeath();
    }

    public void IncreaseHealth(float healing)
    {
        health += healing;
    }

    public void ResetHealth()
    {
        health = 1;
    }

    void CheckDeath()
    {
        if(health <= 0)
        {
            if(DepleteHealth != null)
            {
                Debug.Log("Deplete Health ran");
                DepleteHealth();
            }
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        Debug.Log("collision with " + coll.gameObject.name);
        Destroy(coll.gameObject);
        DecreaseHealth(0.1f);
    }
}
