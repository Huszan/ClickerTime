using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickingText : MonoBehaviour
{
    [Header("//Objects//")]
    public Text text;
    public Button button;
    public Clicking click;
    public GameManager gm;
    [Header("//Values//")]
    public value chooseValue;
    [Header("//Text//")]
    public string textBefore;
    public string textAfter;

    public enum value { Level, Cost, Income, Improvement };

    public string createSentece(string textBefore, string textMiddle, string textAfter)
    {
        return textBefore + textMiddle + textAfter;
    }
    public void writeLevel()
    {
        text.text = createSentece(textBefore, click.level.ToString(), textAfter);
    }
    public void write(long[] value)
    {
        bool first = true; string sentence;
        for (int i=value.Length-1; i>=0; i--)
        {
            if (i == 0 && value[i] < 1000000)
            {
                first = true;
                sentence = "";
            }
            else 
            {
                if (i != 0) first = false;
                else first = true;
                sentence = "." + gm.pullDecimal(value, i, first); 
            }
            if (value[i] != 0)
            {
                text.text = createSentece
                    (textBefore,
                    gm.convertValue(value, i, first).ToString()+sentence,
                    gm.addExtension(value, i, first));
               break;
            }
        }
        text.text = createSentece
                    (textBefore,
                    gm.convertValue(value, 0, first).ToString(),
                    gm.addExtension(value, 0, first));
    }
    private void Update()
    {
        switch (chooseValue) {
            case value.Level:
                writeLevel();
                break;
            case value.Cost:
                write(button.cost);
                break;
            case value.Income:
                write(click.clickImprovement);
                break;
            case value.Improvement:
                write(click.clickIncome);
                break;
        }
        
        
    }
}
