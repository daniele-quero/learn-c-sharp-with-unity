using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop01 : MonoBehaviour
{

    void Start()
    {
        //while loop checks the condition BEFORE running the code
        //so it may not run at all

        int i = 0;
        while (i < 5)
        {
            Debug.Log(i);
            i++;
        }//runs and stops at 4

        i = 5;
        while (i < 5)
        {
            Debug.Log(i);
            i++;
        }//does not run
    }

}
