using UnityEngine;
public class RotateTowardsTransform : MonoBehaviour 
{
	[SerializeField]
	private Transform transformToFollow;

	void Update () 
	{
		updateRotation ();
	}

	void updateRotation()
	{

		Vector3 relativePos = transformToFollow.position - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos);
		transform.rotation = rotation;
	}
}
