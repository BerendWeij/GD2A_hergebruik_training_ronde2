using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	[SerializeField]
	private float speed = 5f;
	public float damage = 20f;

	private bool hitted = false;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().velocity = transform.forward * speed;
	}
	void OnTriggerEnter(Collider coll)
	{
		if (coll.gameObject.GetComponent<Character> () && !hitted) {
			Debug.Log ("hit!");
			hitted = true;
			coll.gameObject.GetComponent<Character> ().Health -= damage;
		}
		Destroy (gameObject);

	}

}
