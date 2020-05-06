using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerText : MonoBehaviour
{
    public Text text;
    public Timer timer;

    void Update()
    {
        text.text = ((int)(timer.countdown - timer.timer)/60).ToString()+"m "+ ((int)(timer.countdown - timer.timer)%60).ToString()+"s";
    }
}
