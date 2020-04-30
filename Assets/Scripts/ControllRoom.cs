using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ControllRoom : MonoBehaviour
{
    Text TimeToLast;
    private DateTime timerEnd;

    // Start is called before the first frame update
    void Start()
    {
        timerEnd = DateTime.Now.AddSeconds(Timer.timer);
        TimeToLast = GetComponent<Text>();
    }

    void FixedUpdate()
    {
        TimeSpan delta = Timer.delta;
        if (delta.TotalSeconds >= 0)
        {
            TimeToLast.text = delta.Minutes.ToString("00") + ":" + delta.Seconds.ToString("00");
            if (delta.TotalSeconds < 11)
            {
                var color = TimeToLast.color;
                color.r = 1.0f;
                color.b = 0.0f;
                color.g = 0.0f;
                TimeToLast.color = color;
            }
            else
            {
                var color = TimeToLast.color;
                color.r = 1.0f;
                color.b = 1.0f;
                color.g = 1.0f;
                TimeToLast.color = color;
            }
        }
    }
}
