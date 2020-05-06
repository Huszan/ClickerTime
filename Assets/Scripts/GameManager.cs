using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scene = 0;
    public string[,] extensionMoney = new string[10, 5]; // Saves "names" of extensions

    public void Start()
    {
        extensionMoney[0, 0] = "";
        extensionMoney[0, 1] = "";
        extensionMoney[0, 2] = "Million";
        extensionMoney[0, 3] = "Billion";
        extensionMoney[0, 4] = "Trillion";
        extensionMoney[1, 0] = "Quadrillion";
        extensionMoney[1, 1] = "Sextillion";
        extensionMoney[1, 2] = "Septillion";
        extensionMoney[1, 3] = "Octillion";
        extensionMoney[1, 4] = "Nonillion";
        extensionMoney[2, 0] = "Decillion";
        extensionMoney[2, 1] = "Undecillion";
        extensionMoney[2, 2] = "Duodecillion";
        extensionMoney[2, 3] = "Tredecillion";
        extensionMoney[2, 4] = "Quattuordecillion";
        extensionMoney[3, 0] = "Quindecillion ";
        extensionMoney[3, 1] = "Sexdecillion";
        extensionMoney[3, 2] = "Septendecillion";
        extensionMoney[3, 3] = "Octodecillion";
        extensionMoney[3, 4] = "Novemdecillion";
        extensionMoney[4, 0] = "Vigintillion";
        extensionMoney[4, 1] = "a";
        extensionMoney[4, 2] = "A";
        extensionMoney[4, 3] = "b";
        extensionMoney[4, 4] = "B";
        extensionMoney[5, 0] = "c";
        extensionMoney[5, 1] = "C";
        extensionMoney[5, 2] = "d";
        extensionMoney[5, 3] = "D";
        extensionMoney[5, 4] = "e";
        extensionMoney[6, 0] = "E";
        extensionMoney[6, 1] = "f";
        extensionMoney[6, 2] = "F";
        extensionMoney[6, 3] = "g";
        extensionMoney[6, 4] = "G";
        extensionMoney[7, 0] = "h";
        extensionMoney[7, 1] = "H";
        extensionMoney[7, 2] = "i";
        extensionMoney[7, 3] = "I";
        extensionMoney[7, 4] = "j";
        extensionMoney[8, 0] = "J";
        extensionMoney[8, 1] = "k";
        extensionMoney[8, 2] = "K";
        extensionMoney[8, 3] = "l";
        extensionMoney[8, 4] = "L";
        extensionMoney[9, 0] = "m";
        extensionMoney[9, 1] = "M";
        extensionMoney[9, 2] = "n";
        extensionMoney[9, 3] = "N";
        extensionMoney[9, 4] = "o";
    }

    public long pullDecimal(long[] value, int number, bool first)
    {
        if (value[number] < 1000 && !first) return value[number-1] / 10000000000000;

        else if (value[number] >= 1000 && value[number] < 1000000 && !first) return (value[number] / 10) - ((value[number] / 1000) * 100);

        else if (value[number] < 1000000 && first) return 0;

        else if (value[number] >= 1000000 && value[number] < 1000000000) return (value[number] / 10000) - ((value[number] / 1000000) * 100);

        else if (value[number] >= 1000000000 && value[number] < 1000000000000) return (value[number] / 10000000) - ((value[number] / 1000000000) * 100);

        else if (value[number] >= 1000000000000 && value[number] < 1000000000000000) return (value[number] / 10000000000) - ((value[number] / 1000000000000) * 100);

        else return 0;
    }
    public long convertValue(long[] value, int number, bool first)
    {
        if (value[number] < 1000 && !first) return value[number];

        else if (value[number] >= 1000 && value[number] < 1000000 && !first) return value[number] / 1000;

        else if (value[number] < 1000000 && first) return value[number];

        else if (value[number] >= 1000000 && value[number] < 1000000000) return (value[number] / 1000000);

        else if (value[number] >= 1000000000 && value[number] < 1000000000000) return (value[number] / 1000000000);

        else if (value[number] >= 1000000000000 && value[number] < 1000000000000000) return (value[number] / 1000000000000);

        else return 0;
    }
    public string addExtension(long[] value, int number, bool first)
    {
            if (value[number] < 1000 && !first) return " " + extensionMoney[number, 0];

            else if (value[number] >= 1000 && value[number] < 1000000 && !first) return " " + extensionMoney[number, 1];

            else if (value[number] >= 1000000 && value[number] < 1000000000) return " " + extensionMoney[number, 2];

            else if (value[number] >= 1000000000 && value[number] < 1000000000000) return " " + extensionMoney[number, 3];

            else if (value[number] >= 1000000000000 && value[number] < 1000000000000000) return " " + extensionMoney[number, 4];

            return null;
    }
}
