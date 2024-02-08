using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SurvivalTimer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timeIsRunning = true;
    public TMP_Text timeText;
    void Start()
    {
        timeIsRunning = true;
    }

 
    void Update()
    {
       if (timeIsRunning)
        {
            if (timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }

       void DisplayTime (float timeToDiplay)
        {
            timeToDiplay += 1;
            float minutes = Mathf.FloorToInt(timeToDiplay / 60);
            float seconds = Mathf.FloorToInt(timeToDiplay % 60);
            timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        }
    }
}
