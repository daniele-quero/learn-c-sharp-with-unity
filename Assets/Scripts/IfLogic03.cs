using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfLogic03 : MonoBehaviour
{
    [SerializeField]
    private int _hits = 0;


    // set color to white
    // implement logic of hits from IfLogic01 script
    // if _hits is multiple of 20, set color to green
    // if color is green, set to white

    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _hits++;
            Debug.Log("Hits: " + _hits);
            if (GetComponent<SpriteRenderer>().color == Color.green)
                GetComponent<SpriteRenderer>().color = Color.white;
        }

        if (_hits != 0 && _hits % 20 == 0)
        {
            GetComponent<SpriteRenderer>().color = Color.green;

        }
    }
}
