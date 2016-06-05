using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerWeapon : MonoBehaviour
{
    private List<IWeapon> weaponList = new List<IWeapon>();
    [SerializeField] private int currWeapon;

    /*
        0 = Pistol
        1 = SMG
        2 = Sniper
    */

	void Awake ()
    {
        IWeapon[] weapons = GetComponents<IWeapon>();

        foreach (IWeapon weapon in weapons)
            weaponList.Add(weapon);
	}

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            FireWeapon();

        ScrollWeaponList();
    }

    void FireWeapon()
    {
        weaponList[currWeapon].Shoot();
    }

    void ScrollWeaponList()
    {
        if (currWeapon < 0)
            currWeapon = 2;
        else if (currWeapon > 2)
            currWeapon = 0;

        //Switch with Scroll
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
            currWeapon++;
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
            currWeapon--;
    }
}
