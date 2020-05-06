using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public long[] points;
    public Text pointsText;
    public GameManager gm;
    void Update()
    {
        //showValue();
        checkBounds(points);
        checkIfNotMinus(points);
    }
 
   
    public void addValue(int level, long[] clickIncome)
    {
        for (int i = 0; i <= points.Length - 1; i++)
            points[i] += level * clickIncome[i];
    }
    public void checkBounds(long[] value)
    {
        for(int i = 0; i < 10; i++)
        {
            if (value[i] >= 1000000000000000)
            {
                value[i + 1] += 1;
                value[i] -= 1000000000000000;
            }
            
        }
    }
    public void checkIfNotMinus(long[] value)
    {
        for ( int i = 0; i <= points.Length - 1; i++ )
        {
            if(value[i] < 0)
            {
                value[i + 1]--;
                value[i] += 1000000000000;
            }
        }
    }
}
    