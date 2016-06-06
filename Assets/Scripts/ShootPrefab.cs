using UnityEngine;
using System.Collections;

public class ShootPrefab : MonoBehaviour {

    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private Transform spawnPoint;

    [SerializeField]
    private float fireRate = 30;

    private float fireRateCounter;

    private void FixedUpdate()
    {
        if (fireRateCounter >= fireRate) {
            Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
            fireRateCounter = 0;
        }
        fireRateCounter++;
    }
}
