using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method01 : MonoBehaviour
{

    public GameObject cube;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ChangeColor(cube, Color.red);
    }

    private void ChangeColor(GameObject obj, Color color)
    {
        if (obj != null)
            obj.GetComponent<MeshRenderer>().material.color = color;
    }
}
