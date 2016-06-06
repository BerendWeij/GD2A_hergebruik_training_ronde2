using UnityEngine;
public class Health : MonoBehaviour 
{
	[SerializeField]
	protected float myHealth = 100;

	[SerializeField]
	protected float maxHealth;

	[SerializeField]
	protected float minHealth;

	[SerializeField]
	DrawBar bar;

	public float MyHealth
	{
		get { return myHealth; }
		set { myHealth = Mathf.Clamp(value,minHealth,maxHealth); }
	}

	public float MaxHealth
	{
		get { return maxHealth; }
	}

	void Update(){
		if (bar) {
			bar.barValue = myHealth;
		}
	}
}
