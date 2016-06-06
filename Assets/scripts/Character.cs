using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character : MonoBehaviour {

	[SerializeField] protected CharacterController controller;

	[SerializeField] public List<Item> inventory = new List<Item>();
	[SerializeField] int selectedItem = 0;
	public int SelectedItem {
		get { return selectedItem; }
		set { selectedItem = value % inventory.Count; }
	}

	[SerializeField] float moveSpeed = 5;

	[SerializeField]
	float health = 100;
	public float Health {
		
		get { return health; }

		set {
			
			health = value;

			if (health <= 0) {

				Debug.Log (gameObject.name + " DIED MUHAHAH");
				GameObject.Destroy (gameObject);
			}
		}
	}

	protected virtual void Awake() {
		controller = gameObject.GetComponent<CharacterController> ();
	}


	protected void Move( Vector3 direction ) {

		if (controller) {

			controller.Move ( direction.normalized * moveSpeed * Time.deltaTime );
		}
	}
}
