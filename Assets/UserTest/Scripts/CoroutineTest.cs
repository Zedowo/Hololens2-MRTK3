using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void awake()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        while (true)
        {
            Debug.Log("First Print");
            Debug.Log("Second Print");
            yield return new WaitForSeconds(5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
