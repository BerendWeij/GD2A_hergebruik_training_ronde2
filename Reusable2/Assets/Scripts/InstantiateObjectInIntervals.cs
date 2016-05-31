using UnityEngine;
using System.Collections;
public class InstantiateObjectInIntervals : MonoBehaviour 
{
	[SerializeField]
	private GameObject objectToSpawn;
	[SerializeField]
	private int interval = 10;
	void Start () 
	{
		StartCoroutine (intervalTimer ());
	}
	IEnumerator intervalTimer()
	{
		yield return new WaitForSeconds (interval);
		Instantiate (objectToSpawn,this.transform.position, transform.localRotation);
		StartCoroutine (intervalTimer ());
	}
}
