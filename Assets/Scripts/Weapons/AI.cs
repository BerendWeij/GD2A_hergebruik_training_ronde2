using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

    [SerializeField]
    private Movement movement;
    private float x = 1;
    private float z = 1;
    

	void Start () {
        
        InvokeRepeating("UpdateVelocity", 0, 0.5f);

    }

    void UpdateVelocity()
    {
        ChangeDirection();
        movement.SettingVelocity(x*2, z*2);
        
    }
	public void ChangeDirection()
    {
        x = -1 + Random.value * 2;
        z = -1 + Random.value * 2;
    }
}
