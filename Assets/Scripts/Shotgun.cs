using UnityEngine;
using System.Collections;

public class Shotgun : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerShoot.OnShotgunEvent += Shoot;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Shoot()
    {
        GameObject rocket = Instantiate(Resources.Load("Shotgun", typeof(GameObject)), transform.position, Quaternion.identity) as GameObject;
    }
}
