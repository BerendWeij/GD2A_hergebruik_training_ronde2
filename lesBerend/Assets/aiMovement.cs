using UnityEngine;
using System.Collections;

public class aiMovement : MonoBehaviour {

    [SerializeField] private Rigidbody target;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(randomMovement());
    }

    IEnumerator randomMovement()
    {
        while (true)
        {
            float randomXSpeed = Random.Range(-10, 10);
            target.velocity = new Vector3(randomXSpeed, target.velocity.y, target.velocity.z);
            yield return new WaitForSeconds(.5f);
            float randomZSpeed = Random.Range(-10, 10);
            target.velocity = new Vector3(target.velocity.x, target.velocity.y, randomZSpeed);
            yield return new WaitForSeconds(.5f);
        }
    }
}
