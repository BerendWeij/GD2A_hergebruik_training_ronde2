using UnityEngine;
using System.Collections;

public class DestroySelf : MonoBehaviour {

    [SerializeField]
    private float lifeTime = 2000;

    private float counter = 0;

    [SerializeField]
    bool _destroyMe;

    void FixedUpdate()
    {
        if (_destroyMe)
        {
            if (counter > lifeTime)
            {
                Destroy(this.gameObject);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag(Tags.damageAble))
        {
            if (_destroyMe)
            DestroyObject(gameObject, 1);

            print("hihi, yours sincerely: " + collision.gameObject.name);
        }
    }
}
