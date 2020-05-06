using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public Clicking click;
    public Points point;
    public AudioSource audioS;

    public long[] cost;
    public long[] costAdd;
    public long[] costAddIncrease;
    private int count;

    private void Update()
    {
        point.checkBounds(cost);
        point.checkBounds(costAdd);
        point.checkBounds(costAddIncrease);
    }
    public void addPoints()
    {
            for (int i = cost.Length - 1; i >= 0; i--)
            {
                if (point.points[i] >= cost[i]) count++;
                else
                {
                    for (int j = i; j <= cost.Length - 2; j++)
                    {
                        if (point.points[j + 1] > cost[j + 1])
                        {
                            count++;
                            break;
                        }
                    }
                }
            }

            if (count == 10)
            {
                audioS.Play();
                click.level++;
                for (int i = 0; i <= cost.Length - 1; i++)
                {
                    point.points[i] -= cost[i];
                    cost[i] += costAdd[i];
                    costAdd[i] += costAddIncrease[i];
                }
            }
            count = 0;
        }
    }


