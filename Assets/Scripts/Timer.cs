using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int countDownStartValue;
    public Text timerUI;
    public float resetdelay;

    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "Timer " + spanTime.Minutes + " " + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            timerUI.text = "WIN!";

            TheGameManager.instance.Win();
            Invoke("reset", resetdelay);
        }
    }
    

    void reset()
    {
        Time.timeScale = 1.0f;
        TheGameManager.instance.Win();
    }
}

