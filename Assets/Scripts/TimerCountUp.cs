 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimerCountUp : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public bool isTimerRunning = true;
    float elapsedTime = 0f;
    int seconds, minutes;

    void Start()
    {
       
    }

    void Update()
    {
        if (isTimerRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerText(elapsedTime);

        }
        else
        {
            timerText.text = "00:00";
        }
    }
    public void UpdateTimerText(float timeInSeconds)
    {
         minutes = (int)(timeInSeconds / 60);
         seconds = (int)(timeInSeconds % 60);
        timerText.text = string.Format("{0}:{1}", minutes.ToString("00"), seconds.ToString("00"));
    }


    public void StopTimer()
    {
        isTimerRunning = false;
        
    }
}
