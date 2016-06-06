using UnityEngine;
using System.Collections;

public class TurretBase : MonoBehaviour {
    
    [serializeField]
    Guns CurrGun;
	[serializeField]
	float coolDown, lastShot;

	GameObject target;

	void Awake() {
		target = GameObject.FindGameObjectsWithTag("Player");

		if (target)
			StartCoroutine (Update);
	}


	IEnumerator Update() {
		transform.LookAt (target);

		if (lastShot > Time.time + coolDown) {
			CurrGun.Shoot (transform);
			lastShot = Time.time;
		}

		yield return new WaitForNextFrame ();
	}
}
