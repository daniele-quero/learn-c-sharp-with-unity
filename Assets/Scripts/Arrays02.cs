using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays02 : MonoBehaviour
{
    public GameObject[] squares;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            foreach (var sq in squares)
                sq.GetComponent<SpriteRenderer>().color = Color.cyan;
    }
}
