using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileLoops : MonoBehaviour
{   

    // Start is called before the first frame update
    void Start()
    {
        bool shouldConinue = false;

        do
        {
            print("Hello World");
        }
        while (shouldConinue == true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
