using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour
{ 
    [SerializeField] private LayerMask playerLayer;
    [SerializeField] private int turretDamage;
    [SerializeField] private float turretRange;
    [SerializeField] private float turretCooldown;
    [SerializeField] private bool showTurretRange;
    private GameObject enemyFound;

	void Start ()
    {
        InvokeRepeating("SearchForEnemy", 0, turretCooldown);
	}

    void SearchForEnemy()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, turretRange);

        if (enemies.Length == 0)
            return;

        enemyFound = enemies[0].gameObject;

        if (enemyFound != null)
        {
            PlayerHealth playerHealth = enemyFound.GetComponent<PlayerHealth>();
            playerHealth.ApplyDamage(turretDamage);
            print("We hit " + enemyFound.name + " for " + turretDamage + " Damage");
        }
    }

    void OnDrawGizmosSelected()
    {
        if (showTurretRange)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, turretRange);
        }
    }
}
