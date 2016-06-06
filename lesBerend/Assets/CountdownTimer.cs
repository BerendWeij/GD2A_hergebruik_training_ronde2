using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] private Text countdownText;
    [SerializeField] private float amountOfTime;

    void Update()
    {
        if (amountOfTime <= 0)
            countdownText.text = "Time over!";
        else
            SetTimerText();
    }

    void SetTimerText()
    {
        amountOfTime -= Time.deltaTime;

        var minutes = amountOfTime / 60;
        var seconds = amountOfTime % 60;
        var fractions = (amountOfTime * 100) % 100;

        countdownText.text = string.Format("Time left: {0:00}:{1:00}:{2:00}", Mathf.Floor(minutes), seconds, fractions);
    }

}
