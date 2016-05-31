using UnityEngine;
public class InputMovement : MonoBehaviour 
{
	[SerializeField]
	private float walkSpeed = 10.0F;
	[SerializeField]
	private float rotationSpeed = 100.0F;

	void Update () 
	{
		float translation = Input.GetAxis("Vertical") * walkSpeed * Time.deltaTime;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);
	}
}
