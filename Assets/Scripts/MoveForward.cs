using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

    [SerializeField]
    private float speed = 1;

    void FixedUpdate() {
        transform.Translate(-Vector3.right * speed * Time.deltaTime);
    }
}
