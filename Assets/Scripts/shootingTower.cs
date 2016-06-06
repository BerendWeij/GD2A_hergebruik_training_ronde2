using UnityEngine;
using System.Collections;

public class shootingTower : MonoBehaviour {

	[SerializeField]
	private GameObject bullet;
    private float cooldown;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.identity);
            cooldown = 2f;
        }
	    
	}
}
