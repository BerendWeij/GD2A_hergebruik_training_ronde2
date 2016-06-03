using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {

    [SerializeField]
    private HealhPlayer playerHealth;

    void Start()
    {
        playerHealth.DepleteHealth += Die;
    }

    void Die()
    {
        Debug.Log("JE BENT HARSTIKKE DOOD");
        playerHealth.DepleteHealth -= Die;
    }
}
