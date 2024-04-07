using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
  
    public float NumberOne;
    public float NumberTwo;
    public float Result;

    [Space]
    public float NumberFree;
    public float NumberFour;
    public float Result1;

    [Space]
    public float NumberFive;
    public float NumberSix;
    public float Result2;

    [Space]
    public float NumberSeven;
    public float NumberEight;
    public float Result3;

    private void Start()
    {
        Sum();
        Minus();
        Mult();
        Devision();
    }
    void Sum()
    {
        Result = NumberOne + NumberTwo;

        Debug.Log(Result);
    }
    void Minus()
    {
        Result1 = NumberFree - NumberFour;

        Debug.Log(Result1);
    }
    void Mult()
    {
        Result2 = NumberFive * NumberSix;
        Debug.Log(Result2);
    }
    void Devision()
    {
        Result3 = NumberSeven / NumberEight;
        Debug.Log(Result3);
    }



}
