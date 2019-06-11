using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempoMarcado : MonoBehaviour
{
    public Text timerText;
    private float time;

    private void Start()
    {
        time = Dados.tempo;
        string minutes = ((int)time / 60).ToString();
        string seconds = (time % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }
}
