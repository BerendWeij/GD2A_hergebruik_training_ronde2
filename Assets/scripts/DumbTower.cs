using UnityEngine;
using System.Collections;

public class DumbTower : Enemy {

	[SerializeField] float radius = 5f;


	void FixedUpdate () {

		foreach (Collider col in Physics.OverlapSphere (transform.position, radius, 1 << 10)) {

			transform.LookAt (col.transform.position);
			inventory [SelectedItem].useItem ();
		}
	}
}
