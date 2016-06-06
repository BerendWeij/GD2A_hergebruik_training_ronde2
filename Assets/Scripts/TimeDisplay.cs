using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

    private Text timeText;
    private float time = 60;

	// Use this for initialization
	void Start () {
        timeText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        timeText.text = "Timeleft: " + time;
	}
}
