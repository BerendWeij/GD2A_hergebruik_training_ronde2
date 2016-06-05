using UnityEngine;
using System.Collections;

public class Sniper : MonoBehaviour, IWeapon
{
    public void Shoot()
    {
        print("I shot my Sniper!");
    }
}
