using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	private Rigidbody player;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float rotationSpeed;


    [SerializeField]
    private GameObject Bullet;

    [SerializeField]
    private GameObject BulletTwo;

    [SerializeField]private List<GameObject> weapons;

	void Start () {
        weapons = new List<GameObject>();
		player = GetComponent<Rigidbody> ();
        //weapons.Add(Resources.Load("Rocket"));
	}

    void Update()
    {
        player.transform.Rotate(0, Input.GetAxis("Mouse X") * rotationSpeed, 0);
        player.transform.position += transform.forward * Time.deltaTime * (Input.GetAxis("Mouse Y") * speed);

        if (Input.GetKeyDown("space"))
        {
            GameObject rocket = Instantiate(Bullet, new Vector3(transform.position.x + 1.5f, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
        }

        if (Input.GetKeyDown("r"))
        {
            GameObject rocket = Instantiate(BulletTwo, new Vector3(transform.position.x + 1.5f, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;

        }
    }
}
