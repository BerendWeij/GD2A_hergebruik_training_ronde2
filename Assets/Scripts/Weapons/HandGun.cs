using UnityEngine;
using System.Collections;

public class HandGun : MonoBehaviour, IWeapon {
	
	public void Shoot() {
		Debug.Log("shooting HandGun");
	}
}
