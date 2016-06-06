using UnityEngine;
using System.Collections;

public class living : MonoBehaviour, IDamageable
{
    [SerializeField]
    protected float health = 100;
    // Use this for initialization
    void Start () {
	
	}

    public void damage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);
            death();
        }
    }
    virtual protected void death()
    {

    }
}
