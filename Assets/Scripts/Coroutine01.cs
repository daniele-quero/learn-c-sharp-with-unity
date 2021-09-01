using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine01 : MonoBehaviour
{
    private bool _isHidden = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isHidden && Input.GetKeyDown(KeyCode.I))
            StartCoroutine(HideRoutine());
    }

    private IEnumerator HideRoutine()
    {
        GetComponent<MeshRenderer>().enabled = false;
        _isHidden = true;
        yield return new WaitForSeconds(5f);
        GetComponent<MeshRenderer>().enabled = true;
        _isHidden = false;
    }
}
