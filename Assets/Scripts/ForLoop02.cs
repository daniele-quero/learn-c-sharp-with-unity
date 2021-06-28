using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop02 : MonoBehaviour
{


    void Start()
    {
        //Iteration with logic: print only odd numbers
        for (int i = 0; i < 10; i++)
        {
            // % (modulus operator returns the remainder of the division i / 2, if it's 0 -> even, otherwise -> odd
            if (i % 2 != 0)
                Debug.Log(i);
        }


        //use of break and continue keywords
        for (int i = 0; i < 50; i++)
        {
            //skips a step each when i is even
            if (i % 2 == 0)
                continue;

            //exits the loop when i = 37
            if (i == 37)
                break;

            Debug.Log(i);
        }
    }


}
