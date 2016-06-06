using UnityEngine;
using System.Collections;

public class Gun : Item {

	[SerializeField] float fireCooldown = 1;
	float currentFireCooldown = 0;

	[SerializeField]
	float damage = 20;

	[SerializeField]
	private GameObject projectile;
	[SerializeField]
	private float offset = 5;


	public override void useItem ()
	{

		if (projectile != null && Time.time > currentFireCooldown) {
			currentFireCooldown = Time.time + fireCooldown;

			GameObject newProjectile = Instantiate (projectile, transform.position + transform.forward * offset, transform.rotation) as GameObject;
			newProjectile.GetComponent<Projectile> ().damage = damage;
		}
		Debug.Log ("PEW");
	}
}
