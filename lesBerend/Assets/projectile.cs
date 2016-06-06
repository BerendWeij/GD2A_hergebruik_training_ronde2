using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour
{

    [SerializeField]
    private LayerMask collisionMask;
    
    public Vector3 _target;
    private Vector3 aim;
    
    private float rangeTraveled;
    [SerializeField]
    private float damage;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float range;


    void Start()
    {
        rangeTraveled = 0;
        aim = (_target - transform.position).normalized;
    }
    void FixedUpdate()
    {
        float moveDistance = speed * Time.deltaTime;
        if (range > rangeTraveled)
        {
            CheckCollisions(moveDistance);
            transform.Translate(aim * moveDistance);
            rangeTraveled += moveDistance;
        }
        else
        {
            GameObject.Destroy(gameObject);
        }
    }
    void CheckCollisions(float moveDistance)
    {
        Ray ray = new Ray(transform.position, aim);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, moveDistance + .2f, collisionMask, QueryTriggerInteraction.Collide))
        {
            OnHitObject(hit);
        }
    }

    void OnHitObject(RaycastHit hit)
    {
        IDamageable damageableObject = hit.collider.GetComponent<IDamageable>();
        if (damageableObject != null)
        {
            damageableObject.damage(damage);
        }
        GameObject.Destroy(gameObject);
    }
}
