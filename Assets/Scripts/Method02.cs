using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method02 : MonoBehaviour
{
    private int _lives = 3;

    // Update is called once per frame
    void Update()
    {
        if (isAlive() && Input.GetKeyDown(KeyCode.Space))
            Damage(1);
    }

    private void Damage(int dmg)
    {
        _lives -= dmg;
        if (_lives < 0)
            _lives = 0;

        Debug.Log("lives: " + _lives);
    }

    private bool isAlive()
    {
        return _lives > 0;
    }
}

