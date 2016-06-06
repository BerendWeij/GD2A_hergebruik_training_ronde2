using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerWeapon : MonoBehaviour {

	private IWeapon currentWeapon;
	private IWeapon[] weapons;

    void Start()
    {
		weapons = GetComponents<IWeapon> ();
    }

    void OnMouseDown()
    {
		int randomIndex = Random.Range (0, weapons.Length);

		currentWeapon = weapons[randomIndex];
		currentWeapon.Shoot ();
	}
}
