using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

    // Use this for initialization
    void Start () {
        PlayerShoot.OnRocketEvent += Shoot;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Shoot()
    {
        GameObject rocket = Instantiate(Resources.Load("Rocket", typeof(GameObject)), transform.position, Quaternion.identity) as GameObject;
    }
}
