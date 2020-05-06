﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public float countdown;
    public bool canCount = false;
    public bool merchant = false;

        void Update()
        {
            if (timer >= 0.0f && canCount)
            {
                timer += Time.deltaTime;
            }
        }

}
