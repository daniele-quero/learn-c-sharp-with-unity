using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfLogic02 : MonoBehaviour
{
    [SerializeField]
    private int _damage = 0,
        _critical, _superCritical, _dice;

    // set the dice
    // set the threshold for critical effects
    // roll the dice
    // if damage >= super critical, set related message
    // if damage <super critical but >= critical, set related message
    // if damage < critical, set related message
    // print message

        //remembere that an if- else if clause is such that if a condition is met, the others are not even checked
    void Start()
    {
        _dice = 20;
        _critical = (int)(_dice * .75f);
        _superCritical = (int)(_dice * .95f);

        _damage = Random.Range(1, 21);
        string message = "Damage done: " + _damage;

        if (_damage >= _superCritical)
            message = message + "\n SUPER CRITICAL EFFECT!!";
        else if(_damage >= _critical)
            message = message + "\n CRITICAL EFFECT!!";
        else
            message = message + "\n normal effect";

        Debug.Log(message);
    }

 
}
