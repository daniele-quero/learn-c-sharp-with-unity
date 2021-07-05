using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch01 : MonoBehaviour
{
    private int _points = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _points += 100;
        }

        if (_points > 1000)
            _points = 1000;

        switch (_points)
        {
            case 0:
                Debug.Log("Loser.. or Beginner :)");
                break;
            case 200:
                Debug.Log("Meh!");
                break;
            case 500:
                Debug.Log("You can do better!");
                break;
            case 800:
                Debug.Log("Almost there");
                break;
            case 1000:
                Debug.Log("Yeah!!!");
                break;
        }
    }
}
