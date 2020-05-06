using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public Clicking click;
    public Points point;

    public long cost = 0;
    public long costAdd = 0;
    public long costAddIncrease = 0; 


    public void addPoints()
    {
        if(point.points >= cost)
        {
            click.level++;
            point.points -= cost;
            cost += costAdd;
            costAdd += costAddIncrease;
        }    
    }
    }

