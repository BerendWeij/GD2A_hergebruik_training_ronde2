using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    private Transform target;
    private float speed = 10f;
    private float damage = 10f;

	void Start () {
        target = FindObjectOfType<PlayerMovement>().transform;
	}
	
	void Update () {
        if (transform.tag == "Bullet")
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 10f);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (transform.tag == "Bullet")
        {
            if (collider.gameObject.tag == "Player")
            {
                Humanoid humanoid = collider.GetComponent<Humanoid>();
                humanoid.Health -= damage;
                Destroy(gameObject);
            }
        }
        
    }
}
