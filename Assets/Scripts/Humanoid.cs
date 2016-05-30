using UnityEngine;
using System.Collections;

public class Humanoid : MonoBehaviour {

    public delegate void HealthChangeEvent(float input);
    public static event HealthChangeEvent OnHealthChangeEvent;

    [SerializeField] private float health = 100;
    public float Health
    {
        get { return health; }
        set { health = value;
            OnHealthChangeEvent(health);
        }
    }
}
