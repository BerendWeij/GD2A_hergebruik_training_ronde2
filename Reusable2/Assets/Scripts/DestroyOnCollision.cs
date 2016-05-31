using UnityEngine;
public class DestroyOnCollision : MonoBehaviour 
{
	[SerializeField]
	private string collisionString = "put string here";

	void OnCollisionEnter (Collision collision)
	{
		if(collision.gameObject.tag == collisionString)
		{
			Destroy (this.gameObject);
		}
	}
}
