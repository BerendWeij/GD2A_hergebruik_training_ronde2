using UnityEngine;
public class MoveForward : MonoBehaviour 
{
[SerializeField]
private float speed = 2;

	void Update () 
	{
		transform.Translate(transform.forward* speed * Time.deltaTime);
	}
}
