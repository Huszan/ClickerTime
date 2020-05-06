using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class loadingBar : MonoBehaviour
{
    public Image image;
    private float percent;
    public Timer timer;

    public void updateBar()
    {
        percent = timer.timer / timer.countdown;
        image.fillAmount = timer.timer / timer.countdown;
    }
    public void FixedUpdate()
    {
         updateBar();
    }
}
