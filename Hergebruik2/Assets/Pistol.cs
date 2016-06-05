using UnityEngine;
using System.Collections;

public class Pistol : MonoBehaviour, IWeapon
{
	public void Shoot ()
    {
        print("I shot my pistol!");
	}
}
