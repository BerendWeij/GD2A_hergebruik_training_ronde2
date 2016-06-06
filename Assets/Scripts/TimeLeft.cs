using UnityEngine;
using System.Collections;
public class TimeLeft : MonoBehaviour
{
    [SerializeField]
    private float timeLimit;
    private float timeDevision;
    private float timeScaling = 1;
    private Vector3 scale;

    void Start()
    {
        scale = transform.localScale;
        timeDevision = timeLimit / scale.x;
    }

    void FixedUpdate()
    {
        if (timeLimit > 0f)
        {
            timeLimit -= Time.deltaTime * timeScaling;
            scale.x = timeLimit / timeDevision;
            transform.localScale = scale;
        }
        else
            print("Time's Up!");
    }
    public float TimeScaling
    {
        get { return timeScaling; }
        set { timeScaling = value; }
    }
    public float TimeLimit
    {
        get { return timeLimit; }
        set { timeLimit = value; }
    }
}
