using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

    [SerializeField]
    private GameObject target;

    [SerializeField]
    private GameObject bullet;

    private float shotCooldown;

    void Update()
    {
        if (shotCooldown < 0)
            shotCooldown = 0;
        else
            shotCooldown--;

        if(shotCooldown == 0)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            shotCooldown = 120;
        }

        transform.LookAt(target.transform);
    }
}
