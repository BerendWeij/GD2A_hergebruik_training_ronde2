using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class PlayerMovement : MonoBehaviour {

    private float MoveX;
    [SerializeField]
    private float Speed = 5f;
    [SerializeField]
    private Rigidbody2D rigid;
    private string PlayerName;
    // Use this for initialization

    public float newSpeed{get { return Speed; }set { Speed = value; }}

    void Awake () {
        //Get objectname for choosing which keys you use base on Player 1 or 2.
        PlayerName = gameObject.name;
        rigid = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        //Walking around
        MoveX = Input.GetAxisRaw(PlayerName);

        Move();
	}

    void Move()
    {
        // Can Walk if not Jumping
        rigid.velocity = new Vector2(MoveX * Speed, 0);

    }
}
