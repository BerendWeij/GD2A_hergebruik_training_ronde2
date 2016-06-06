using UnityEngine;
using System.Collections;

public class gun3 : MonoBehaviour, Iweapon
{

    [SerializeField]
    private GameObject bullet;
    // Use this for initialization
    void Start()
    {

    }
    public void shoot(Vector3 targetPoint)
    {
        projectile script = bullet.GetComponent<projectile>();
        script._target = targetPoint;
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
