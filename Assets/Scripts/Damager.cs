using UnityEngine;
using System.Collections;

public class Damager : MonoBehaviour {

    [SerializeField]
    private float damage = 20;

    public float Damage
    {
        get { return damage; }
        set { damage = value; }
    }
}
