using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileCoroutine01 : MonoBehaviour
{
    [SerializeField]
    private float _maxSpeed = 5f, _speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //starts coroutine
        StartCoroutine(IncreaseSpeed());
        
    }


    //coroutine
    //increase spead each second
    private IEnumerator IncreaseSpeed()
    {
        while(_speed < _maxSpeed)
        {
            _speed += 0.2f;
            yield return new WaitForSeconds(1f);
        }
    }
}
