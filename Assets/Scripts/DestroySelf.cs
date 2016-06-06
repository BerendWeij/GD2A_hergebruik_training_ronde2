using UnityEngine;
using System.Collections;

public class DestroySelf : MonoBehaviour {

    [SerializeField]
    private float lifeTime = 2000;

    private float counter = 0;

    void FixedUpdate()
    {
        if (counter > lifeTime)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag(Tags.damageAble))
        {
            DestroyObject(gameObject, 1);
        }
    }
}
