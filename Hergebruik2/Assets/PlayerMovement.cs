using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private float speed;

	void MovePlayer ()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rbPlayer.velocity = new Vector2(x * speed, y * speed);
	}

    void FixedUpdate()
    {
        MovePlayer();
    }
}
