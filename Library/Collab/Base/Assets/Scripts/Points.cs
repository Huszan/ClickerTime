using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public long[] points;
    public Text pointsText;
    public GameManager gm;
    void Update()
    {
        showValue();
        checkBounds(points);
        checkIfNotMinus(points);
    }
    public void showValue()
    {
        for (int i = points.Length-1; i >= 0; i--)
        {
            if (points[i] != 0)
            {
                convertValue(points[i], pointsText, gm.extensionMoney, i);
                break;
            }

        }
    }
    public void convertValue(long value, Text valueText, string[,] names, int number)
    {
        //<1000
        if (value < 1000000) valueText.text = value.ToString() + names[number,0];
        //for milions
        if (value > 1000000 && value < 1000000000) valueText.text = (value / 1000000).ToString() + "." + ((value / 10000) - ((value / 1000000) * 100)).ToString() + names[number,1];
        //for miliards
        if (value > 1000000000 && value < 1000000000000) valueText.text = (value / 1000000000).ToString() + "." + ((value / 10000000) - ((value / 1000000000) * 100)).ToString() + names[number,2];
        //for triliards
        if (value > 1000000000000 && value < 1000000000000000) valueText.text = (value / 1000000000000).ToString() + "." + ((value / 10000000000) - ((value / 1000000000000) * 100)).ToString() + names[number, 3];
        if (number == 9 && value >= 1000000000000000)   valueText.text = "Too much to count!";
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
    