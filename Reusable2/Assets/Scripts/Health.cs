using UnityEngine;
public class Health : MonoBehaviour 
{
	[SerializeField]
	private float myHealth = 100;

	[SerializeField]
	private float maxHealth;

	[SerializeField]
	private float minHealth;

	public float MyHealth
	{
		get { return myHealth; }
		set { myHealth = Mathf.Clamp(value,minHealth,maxHealth); }
	}

	public float MaxHealth
	{
		get { return maxHealth; }
	}

}
