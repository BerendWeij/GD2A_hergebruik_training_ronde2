using UnityEngine;
using System.Collections;

//wegens onbekende redenen werkt de collsion tussen de bullet en de player alleen als de player beweegt

public class Bullet : MonoBehaviour {

	void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 2);
    }
}
