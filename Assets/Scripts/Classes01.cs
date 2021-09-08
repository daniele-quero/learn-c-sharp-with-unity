using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes01 : MonoBehaviour
{
    [SerializeField]
    private List<Customer> _customers;
    void Start()
    {
        _customers = new List<Customer>();
        _customers.Add(new Customer("ron", "frajinski", "M", "student", 18));
        _customers.Add(new Customer("jon", "snow", "M", "king in the north", 16));
        _customers.Add(new Customer("jessica", "rabbit", "F", "singer", 30));
    }


}
