using UnityEngine;
public class ChangeHealthOnCollision : MonoBehaviour 
{
	[SerializeField]
	private string collisionString = "put string here";

	[SerializeField]
	private Health health;

	[SerializeField]
	private float healthChangeValue;


	void OnCollisionEnter (Collision collision)
	{
		if(collision.gameObject.tag == collisionString)
		{
			health.MyHealth = health.MyHealth + healthChangeValue;
		}
	}

}
