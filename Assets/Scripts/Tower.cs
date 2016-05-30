using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

    private float cooldown;

	void Start () {
	
	}
	
	void Update () {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0f)
        {
            Shoot();
        }
	}

    void Shoot()
    {
        cooldown = 1f;
        GameObject bullet = Instantiate(Resources.Load("Bullet", typeof(GameObject)),transform.position,Quaternion.identity) as GameObject;
    }
}
