using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Converter : MonoBehaviour
{

    public InputField F, C;
    public static string stringC, stringF;
    public static int Change;
    static float check_time;
    static double rValue;
    static int count = 0;

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
            if(double.Parse(F.text) == rValue) {
                check_time = Time.realtimeSinceStartup - check_time;
                Debug.Log( "check time : " + check_time.ToString("0.000") );
            }
            C.text = FtoC(double.Parse(F.text)).ToString();
        }
        else
        {
            if(double.Parse(C.text) == rValue) {
                check_time = Time.realtimeSinceStartup - check_time;
                Debug.Log( "check time : " + check_time.ToString("0.000") );
            }
            F.text = CtoF(double.Parse(C.text)).ToString();
        }
    }

    public void Start()
    {
        Change = -1;
        check_time = Time.realtimeSinceStartup;
    }

    void PrintRandom() {
        rValue = (double) Random.Range(-999, 1000) / 10.0;
        Debug.Log("input[ "+count+" ] : " + rValue);
        check_time = Time.realtimeSinceStartup;
    }
    void Update()
    {
        if (Change != -1)
        {
            Convert(Change);
            Change = -1;
        }

        if (Input.GetKeyUp(KeyCode.Return)) {
            C.text = "";
            F.text = "";
            PrintRandom();
            count++;
        }
    }
}
