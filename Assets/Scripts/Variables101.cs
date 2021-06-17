using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables101 : MonoBehaviour
{
    public string playerName;
    private int _playerLevel = 1;

    private GameObject _uberMissile;
    public Camera _cameraObj;

    [SerializeField]
    private AudioClip _audio;

    private Vector2 _vec = new Vector2(1f, 2f);
}
