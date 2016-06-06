using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    [SerializeField]
    private string HorizontalInput = "Horizontal";

    [SerializeField]
    private KeyCode jumpButton = KeyCode.W; 

    [SerializeField]
    private float moveSpeed = 0.5f;

    [SerializeField]
    private float jumpSpeed = 4;

    private bool grounded;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
	// Update is called once per frame
	void Update () {
        Vector3 currentVelocity = rb.velocity;
        currentVelocity.x += Input.GetAxis(HorizontalInput) * moveSpeed;

        if (Input.GetKeyDown(jumpButton) && grounded) {
            currentVelocity.y += jumpSpeed;
        }


        rb.velocity = currentVelocity;
    }

    void OnCollisionStay(Collision collision) {
        if (collision.transform.position.y < transform.transform.position.y)
        {
            grounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
}
