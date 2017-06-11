using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendString : MonoBehaviour
{

    // 1 -> F, 0 -> C
    public bool CF;

    public void ValueChanged(string text)
    {
        double result;
        bool isValid = double.TryParse(text, out result);
        if (isValid)
        {
            if (CF)
            {
                Converter.stringF = text;
                Converter.Change = 1;
            }
            else
            {
                Converter.stringC = text;
                Converter.Change = 0;
            }
        }
    }

}
