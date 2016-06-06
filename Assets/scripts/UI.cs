using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UI : MonoBehaviour {

	[SerializeField]
	private Text healthText;
	[SerializeField]
	private Text weaponText;

	[SerializeField]
	private Character character;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		healthText.text = character.Health.ToString();
		weaponText.text = character.inventory [character.SelectedItem].gameObject.name;
	}
}
