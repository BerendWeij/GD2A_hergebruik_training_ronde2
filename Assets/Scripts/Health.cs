using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health;

	[SerializeField]
	private float damage;

	[SerializeField]
	private string hitObject;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider collider)
	{
			health -= damage;
			Debug.Log (health);
			Destroy (collider.gameObject);
	}
}
