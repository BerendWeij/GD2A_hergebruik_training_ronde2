using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour, IHealth
{
    public delegate void ChangeHealthBar();
    public ChangeHealthBar OnPlayerDamage;
    [SerializeField] private int health;
    public int Health
    {
        get { return health; }
    }

    public void ApplyDamage(int damage)
    {
        health -= damage;
        if (OnPlayerDamage != null)
            OnPlayerDamage();
    }

    void Update()
    {
        if (health <= 0)
            Destroy(this.gameObject);
    }
}
