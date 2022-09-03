using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    public Text timer;
    

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timer.text = time.Minutes.ToString() + ":" + time.Seconds.ToString("00");
    }
}