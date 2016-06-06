using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	private Rigidbody player;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float rotationSpeed;

	void Start () {
		player = GetComponent<Rigidbody> ();
	}

	void Update () {
		player.transform.Rotate (0, Input.GetAxis("Horizontal") * rotationSpeed, 0);
		player.transform.position += transform.forward * Time.deltaTime * (Input.GetAxis ("Vertical") * speed);
	}

}
