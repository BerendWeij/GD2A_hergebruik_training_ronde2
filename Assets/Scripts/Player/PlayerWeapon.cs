using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerWeapon : MonoBehaviour {

    private List<IWeapon> currentWeapon;

    [SerializeField]
    private NormalGun normalGun;
    [SerializeField]
    private ShotGun shotGun;
    [SerializeField]
    private Grenade grenadeThrower;
	
    void Start()
    {
        currentWeapon.Add(normalGun);
        currentWeapon.Add(shotGun);
        currentWeapon.Add(grenadeThrower);
    }

    void OnMouseDown()
    {
        currentWeapon = Random.Range(0, 2);
    }
}
