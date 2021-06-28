using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop01 : MonoBehaviour
{

    void Start()
    {
        //Simple use of for loop to iterate a statement
        for(int i = 0; i< 10; i++)
        {
            Debug.Log("Hello " + i);
        }

        Debug.Log("Now, reverse!");
        //Simple example of reverse iteration
        for (int i = 10; i > 0; i--)
        {
            Debug.Log("Hello " + i);
        }
    }

 
}
