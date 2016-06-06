using UnityEngine;
using System.Collections;

public class Player : Character {

	// Use this for initialization
	protected override void Awake ()
	{
		base.Awake ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.C)) {
			SelectedItem++;
			;
		}
		
		if (Input.anyKeyDown && inventory [SelectedItem]) {
			Debug.Log ("Shooting");
			inventory [SelectedItem].useItem ();
		}

		Move (
			new Vector3 (
				Input.GetAxis("Horizontal"),
				0,
				Input.GetAxis("Vertical")
			)
		);
	}
}
