using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays01 : MonoBehaviour
{

    //Array declaration and intialization

    //when visible in an inspector an array can be filled manually
    // if no size is provided by code, inspector will ask for the size
    [SerializeField]
    private string[] _inspectorArray;

    //if size is provided, 5, you can fill the array in the inspector up to 5 elements
    [SerializeField]
    private string[] _hardCodedArray = new string[5];

    //this is how you initialize array on declaration
    [SerializeField]
    private string[] _initializedArray = new string[5] { "aa", "bb", "cc", "dd", "yellowmellow" };
    // Start is called before the first frame update
    void Start()
    {
        //this is how you access an element of an array
        _hardCodedArray[0] = "showtime";
        _hardCodedArray[4] = "mamboooo";
    }

    // Update is called once per frame
    void Update()
    {
        print();
    }

    private void print()
    {
        foreach (var key in (KeyCode[])System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(key))
                switch (key)
                {
                    case KeyCode.R:
                        // print a random element
                        Debug.Log(_initializedArray[Random.Range(0,4)]);
                        break;
                    case KeyCode.A:
                        //print all elements
                        for(int i=0; i<5; i++)
                            Debug.Log(_initializedArray[i]);
                        break;
                    case KeyCode.Alpha1:
                    case KeyCode.Keypad1:
                        // print element of index 1 -- arrays start with 0!!
                        Debug.Log(_initializedArray[1]);
                        break;
                    case KeyCode.W:
                        //alternative print all elements
                        foreach (string el in _initializedArray)
                            Debug.Log(el);
                        break;
                    default:
                        break;

                }
        }

    }
}
