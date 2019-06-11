using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeManager : MonoBehaviour
{

    public Text timerText;
    private float startTime;
    public static float t;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        timer();
        Dados.tempo = t;
    }

    void timer()
    {
        t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }
}
