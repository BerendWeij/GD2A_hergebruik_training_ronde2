using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    [SerializeField]
    private string HorizontalInput = "Horizontal";

    [SerializeField]
    private string VerticalInput = "Vertical";

    [SerializeField]
    private KeyCode jumpButton = KeyCode.W; 

    [SerializeField]
    private float moveSpeed = 0.5f;

    [SerializeField]
    private float jumpSpeed = 4;

    private bool grounded;

    Vector3 currentVelocity;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        currentVelocity = rb.velocity;
    }
    public void SettingVelocity(float dx, float dz)
    {
        currentVelocity.x += dx * moveSpeed;
        currentVelocity.z += dz * moveSpeed;
    }
	// Update is called once per frame
	void Update () {

        SettingVelocity(Input.GetAxis(HorizontalInput), Input.GetAxis(VerticalInput));
        if (Input.GetAxis(VerticalInput) != 0)
            Debug.Log("up");

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
