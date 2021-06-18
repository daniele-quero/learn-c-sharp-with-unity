using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfLogic01 : MonoBehaviour
{
    [SerializeField]
    private int _hits = 0;

    [SerializeField]
    private bool _printedMessage = false;

    // if space bar is pressed, _hits increases by one.
    // if _hits reaches a multiple of 20, a message is printed
    // if the message is printed, a flag is raised
    // if spacebar is pressed and flag is reaied, the flag is lowered
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _hits++;
            Debug.Log("Hits: " + _hits);
            if (_printedMessage)
                _printedMessage = false;
        }

        if (_hits != 0 && _hits % 20 == 0)
        {
            if (!_printedMessage)
            {
                Debug.Log("Awsome!");
                _printedMessage = true;
            }
            
        }
    }
}
