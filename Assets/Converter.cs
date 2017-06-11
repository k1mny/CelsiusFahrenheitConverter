using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Converter : MonoBehaviour
{

    public InputField F, C;
    public static string stringC, stringF;
    public static int Change;

    public static double FtoC(double f)
    {
        return (f - 32.0) / 1.8;
    }

    public static double CtoF(double c)
    {
        return 1.8 * c + 32.0;
    }

    public void Convert(int ForC)
    {
        if (ForC == 1)
        {
            C.text = FtoC(double.Parse(F.text)).ToString();
        }
        else
        {
            F.text = CtoF(double.Parse(C.text)).ToString();
        }
    }

    public void Start()
    {
        Change = -1;
    }
    void Update()
    {
        if (Change != -1)
        {
            Convert(Change);
            Change = -1;
        }
    }
}
