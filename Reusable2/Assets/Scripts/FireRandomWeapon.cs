using UnityEngine;
using System.Collections;

public class FireRandomWeapon : MonoBehaviour {
	[SerializeField]
	private Weapon[] weaponArray;

	void Start()
	{
		weaponArray = GetComponents<Weapon>();
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.Space))
		{
			weaponArray [Random.Range (0, weaponArray.Length)].Fire ();
		}
	}
}
