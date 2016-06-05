using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour, IWeapon {

	public void Shoot()
    {
        print("Throwing Grenade");
    }
}
