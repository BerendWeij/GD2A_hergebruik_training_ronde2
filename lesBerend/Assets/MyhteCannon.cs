using UnityEngine;
using System.Collections;

public class MyhteCannon : MonoBehaviour, Iweapon
{
    [SerializeField]
    private GameObject bullet;
    // Use this for initialization
    public void shoot(Vector3 targetPoint)
    {
        projectile script = bullet.GetComponent<projectile>();
        script._target = targetPoint;
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
