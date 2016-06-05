using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

    [SerializeField]
    private float _bulletSpeed;

    [SerializeField]
    private Rigidbody2D _bulletRigidBody2D;

    void Start()
    {
        MoveBullet();
    }

    void MoveBullet()
    {
        _bulletRigidBody2D.AddForce(new Vector2(_bulletSpeed, 0),ForceMode2D.Impulse);
    }
}
