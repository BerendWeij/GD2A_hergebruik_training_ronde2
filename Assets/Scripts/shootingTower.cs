using UnityEngine;
using System.Collections;

public class shootingTower : MonoBehaviour {

	[SerializeField]
	private GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space"))
		{
			Instantiate (bullet, new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.identity);
		}
	}
}
