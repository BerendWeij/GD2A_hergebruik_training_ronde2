using UnityEngine;
using System.Collections;

public class MemeGun : MonoBehaviour, Iweapon
{
    [SerializeField] private GameObject bullet;
    public void shoot(Vector3 targetPoint)
    {
        projectile script = bullet.GetComponent<projectile>();
        script._target = targetPoint;
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
