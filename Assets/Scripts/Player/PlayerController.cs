using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	[SerializeField] private string moveLeft;
	[SerializeField] private string moveRight;

	private PlayerMovement playermovement;


	void Start()
	{
		playermovement = GetComponent<PlayerMovement> ();
	}

	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(moveLeft))
			{
				playermovement.LeftMove ();

			}
		if (Input.GetKey (moveRight))
		{
			playermovement.RightMove ();
		}

	}
}
