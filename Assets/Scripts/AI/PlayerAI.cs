using UnityEngine;
using System.Collections;

public class PlayerAI : MonoBehaviour {

	private float actionTimer;
	[SerializeField] private float actionTimerBase;

	// Use this for initialization
	void Start () {
	
		actionTimer = actionTimerBase;
	}
	
	// Update is called once per frame
	void Update () {
	
		actionTimer -= Time.deltaTime;
		if (actionTimer <= 0) 
		{
			RandomAction ();
			actionTimer = actionTimerBase;
		}
	}

	void RandomAction()
	{


	}


}
