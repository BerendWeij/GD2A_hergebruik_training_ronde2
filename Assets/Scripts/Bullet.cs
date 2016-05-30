using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rigid;
    private float speed = 20f;
    // Use this for initialization
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 3f);
    }
    void Update() 
    {
        rigid.velocity = new Vector2(0, speed);
    }
}
