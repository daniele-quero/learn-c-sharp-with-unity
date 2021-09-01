using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine02 : MonoBehaviour
{
    public bool goRoutine = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeColor());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator ChangeColor()
    {
        while (goRoutine)
        {

            yield return new WaitForSeconds(2f);
            Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            Debug.Log(randomColor);
            GetComponent<MeshRenderer>().material.color = randomColor; 
        }
        
    }
}
