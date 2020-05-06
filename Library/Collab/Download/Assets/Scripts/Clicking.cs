using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicking : MonoBehaviour
{

    public Points points;
    public Timer timer;
    public long[] clickIncome;
    public long[] clickImprovement;
    public int level = 0;

    public void Income()
    {
        if(level > 0)   timer.canCount = true;
    }

    public void Update()
    {
        for(int i = 0; i < clickIncome.Length-1; i++)
        {
            if (level != 0 && clickIncome[i] != 0) clickImprovement[i] = clickIncome[i] * level;
            else clickImprovement[i] = 0;
        }
        if(timer.timer >= timer.countdown)
        {
            if(timer.merchant == false) timer.canCount = false;
            timer.timer = 0;
            points.addValue(level, clickIncome);
        }
        points.checkBounds(clickIncome);
    }

}
