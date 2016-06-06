using UnityEngine;
using System.Collections;

public class turret : living
{

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform targetPoint;
    // Use this for initialization
    void Start () {
        StartCoroutine(shoot());
	}
    IEnumerator shoot()
    {
        while (true && targetPoint != null)
        {
            projectile script = bullet.GetComponent<projectile>();
            script._target = targetPoint.position;
            Instantiate(bullet, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(0.1f);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
