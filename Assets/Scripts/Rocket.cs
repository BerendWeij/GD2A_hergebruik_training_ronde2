using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

    [SerializeField]
    private float bulletSpeed;

    void Start()
    {
        StartCoroutine(destroy());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * bulletSpeed;
    }

    IEnumerator destroy()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
