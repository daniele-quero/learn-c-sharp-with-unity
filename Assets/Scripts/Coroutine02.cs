using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine02 : MonoBehaviour
{
    public bool goRoutine = true;

    [SerializeField]
    private MeshRenderer _meshRenderer;
    private WaitForSeconds wait;
    // Start is called before the first frame update
    void Start()
    {
        wait = new WaitForSeconds(2f);
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
            yield return wait;
            Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            Debug.Log(randomColor);
            _meshRenderer.material.color = randomColor; 
        }
        
    }
}
