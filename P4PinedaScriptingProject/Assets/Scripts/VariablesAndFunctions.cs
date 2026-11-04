using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;


    // Start is called before the first frame update
    void Start()
    {
        int myInt = 5;
        
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt); 
    }

    // Update is called once per frame
    void Update()
    {
        int result;
        result = NumberFormatInfo * 2;
        return result;
    }
}
