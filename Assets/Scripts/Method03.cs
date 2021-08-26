using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method03 : MonoBehaviour
{
    private Vector3[] _positions = new Vector3[5];
    // Start is called before the first frame update
    void Start()
    {
        GeneratePositions();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            transform.position = RandomPosition();
    }

    private void GeneratePositions()
    {
        for (int i =0; i<5; i++)
        {
            _positions[i] = new Vector3(Random.Range(-4,4f), Random.Range(-4, 4f), Random.Range(-4, 4f));
        }
    }

    private Vector3 RandomPosition()
    {
        return _positions[Random.Range(0, 5)];
    }
}
