using UnityEngine;
using System.Collections;

public class AK12 : Guns {

	GameObject Bullet;
	void Shoot(Transform _startPos) {
		GameObject shot = Instantiate (Bullet, _startPos.position, _startPos.rotation);

		
	}
}
