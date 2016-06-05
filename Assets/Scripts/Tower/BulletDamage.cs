using UnityEngine;
using System.Collections;

public class BulletDamage : MonoBehaviour {

    [SerializeField]
    private int damage;

	void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            coll.gameObject.GetComponent<PlayerHealth>().ChangeHealth(damage, true);
            Destroy(this.gameObject);
        }
    }
}
