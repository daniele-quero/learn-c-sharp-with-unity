using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhile01 : MonoBehaviour
{


    void Start()
    {
        //do-while example. 
        //DO something the first time, then repeat it until the condition is met
        //this will print numbers from 0 to 2, then the condition i<3 is not met anymore
        int i = 0;
        do
        {
            Debug.Log(i);
            i++;
        }
        while (i < 3);

        //this code would print 3 and then stop because the condition is already non met, 
        //but the do-while always runs at least one time and THEN checks the condition
        i = 3;
        do
        {
            Debug.Log(i);
            i++;
        }
        while (i < 3);


    }

}
