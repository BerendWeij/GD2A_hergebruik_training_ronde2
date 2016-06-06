using UnityEngine;
using System.Collections;

public class ShotGun : MonoBehaviour, IWeapon {

	public void Shoot() {
		Debug.Log("shooting ShotGun");
	}
}
