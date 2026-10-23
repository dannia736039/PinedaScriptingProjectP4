using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionmsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This line is there to tell me the x position of the object in the console
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //This if statement is goiing to check the height of my game object
        if(transform.position.y <= 5f)
        {
            Debug.Log("I am about to hit the ground");
        }
        else
        {
            Debug.Log("I am still in the air");
        }
    }
}
