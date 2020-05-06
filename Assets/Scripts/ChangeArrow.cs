using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeArrow : MonoBehaviour
{
    public bool direction; //true-right  false-left
    public SceneChange sc;
    public GameManager gm;

    public int frames = 120;
    private int framesCountdown = 0;
    public float countdown = 0.1f;
    private float timer;
    private bool clicked = false;

    public void onClick()
    {
        if(direction == true && gm.scene < 2)    clicked = true;
        if(direction == false && gm.scene > 0)   clicked = true;
    }

    public void FixedUpdate()
    {
        if (clicked == true && gm.scene <= 1 && direction == true)
        {
            timer += Time.deltaTime;
            if (timer > countdown && framesCountdown < frames)
            {
                sc.transformPos(-1);
                timer = 0;
                framesCountdown++;
            }
            if(framesCountdown == frames)
            {
                gm.scene += 1;
                framesCountdown = 0;
                clicked = false;
            }
        }
        if (clicked == true && gm.scene > 0 && direction == false)
        {
            timer += Time.deltaTime;
            if (timer > countdown && framesCountdown < frames)
            {
                sc.transformPos(1);
                timer = 0;
                framesCountdown++;
            }
            if (framesCountdown == frames)
            {
                gm.scene -= 1;
                framesCountdown = 0;
                clicked = false;
            }
        }
    }

}
