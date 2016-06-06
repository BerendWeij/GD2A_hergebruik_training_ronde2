using UnityEngine;
using System.Collections;

public class DamageAble : MonoBehaviour {

    //delegate type
    public delegate void ChangeHealthMethod(float _healthValue);

    //delegate instance
    public ChangeHealthMethod ChangeHealth;

    [SerializeField]
    private float health = 100;

    void Start()
    {
        if (ChangeHealth != null)
        {
            ChangeHealth(health);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag(Tags.damager))
        {
            health -= collision.transform.GetComponent<Damager>().Damage;

            if (ChangeHealth != null) {
                ChangeHealth(health);
            }
        }
    }
}
