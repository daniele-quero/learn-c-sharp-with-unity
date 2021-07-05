using System;
using UnityEngine;

public class Switch02 : MonoBehaviour
{
    void Update()
    {
        foreach (var key in (KeyCode[])Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(key))
                switch (key)
                {
                    case KeyCode.R:
                        GetComponent<SpriteRenderer>().color = Color.red;
                        break;
                    case KeyCode.G:
                        GetComponent<SpriteRenderer>().color = Color.green;
                        break;
                    case KeyCode.B:
                        GetComponent<SpriteRenderer>().color = Color.blue;
                        break;
                    case KeyCode.Y:
                        GetComponent<SpriteRenderer>().color = Color.yellow;
                        break;
                    case KeyCode.W:
                        GetComponent<SpriteRenderer>().color = Color.white;
                        break;
                    default:
                        GetComponent<SpriteRenderer>().color = Color.black;
                        break;

                }
        }
    }
}
