using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfLogic04 : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4f;

    [SerializeField]
    private Vector2 _direction = Vector2.zero;

    //make the object move by getting Input axis and using translate on transform component
    //define methods that increase or decrease speed by 2
    //define method that restore default speed on 4;
    //call methods if related key is pressed

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Q))
            DecreaseSpead();
        if (Input.GetKeyDown(KeyCode.E))
            IncreaseSpead();
        if (Input.GetKeyDown(KeyCode.R))
            DefaultSpead();
    }

    private void Move()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        _direction.x = xInput;
        _direction.y = yInput;
        transform.Translate(_direction * Time.deltaTime * _speed);
    }

    private void IncreaseSpead()
    {
        _speed += 2f;
    }

    private void DecreaseSpead()
    {
        _speed -= 2f;
    }

    private void DefaultSpead()
    {
        _speed = 4f;
    }
}
