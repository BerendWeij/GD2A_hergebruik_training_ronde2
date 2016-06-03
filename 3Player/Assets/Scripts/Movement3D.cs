using UnityEngine;
using System.Collections;

public class Movement3D : MonoBehaviour {

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private Vector3 rotationVector;

    [SerializeField]
    private Vector3 moveVector;

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * 5, ForceMode.VelocityChange);
        }

        if(Input.GetKey(KeyCode.A))
        {
            Quaternion deltaRotation = Quaternion.Euler(rotationVector * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }

        if(Input.GetKey(KeyCode.D))
        {
            Quaternion deltaRotation = Quaternion.Euler(-rotationVector * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }

        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-Vector3.forward * 5, ForceMode.VelocityChange);
        }
    }
}
