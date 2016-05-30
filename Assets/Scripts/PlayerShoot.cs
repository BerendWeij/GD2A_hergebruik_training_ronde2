using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    public delegate void RocketEvent();
    public static event RocketEvent OnRocketEvent;

    public delegate void ShotgunEvent();
    public static event ShotgunEvent OnShotgunEvent;

    private int weaponInt;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            weaponInt = Random.Range(0,2);
            Debug.Log(weaponInt);
            if (weaponInt == 1)
            {
                OnRocketEvent();
            }
            else
            {
                OnShotgunEvent();
            }
        }
    }
}
