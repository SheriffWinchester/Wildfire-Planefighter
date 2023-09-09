using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimerUI : MonoBehaviour
{
    //public float timeRemaining = 180;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeText;
    void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
        // Starts the timer automatically
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (Singleton.instance.timeRemaining > 0)
            {
                Singleton.instance.timeRemaining -= Time.deltaTime;
                DisplayTime(Singleton.instance.timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                Singleton.instance.timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{00}:{1:00}", minutes, seconds);
    }
}