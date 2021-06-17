using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int _hp = 100, 
        _stamina = 150,
        _strength = 2, 
        _dexterity = 2;

    [SerializeField]
    private string _name = "Timmy";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Current HP: " + _hp);
        Debug.Log("Player " + _name + " is under attack!");
        var damage = GetRandomDamage(6);
        _hp -= damage;
        Debug.Log(_name + " gets " + damage + " of damage!");
        Debug.Log("Current HP: " + _hp);
    }

    private int GetRandomDamage(int dice)
    {
        return Random.RandomRange(1, dice + 1);
    }
}
