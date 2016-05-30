using UnityEngine;
using System.Collections;

public class BulletSpawn : MonoBehaviour {

    public GameObject bullet;
    [SerializeField]
    private Transform spawnPosition;
    private Quaternion rotate;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        spawnPosition = transform;
        rotate = transform.rotation;
        Invoke("spawn", 1f);
	}

    private void spawn() {
       Instantiate(bullet,spawnPosition.position,rotate);
    }
}
