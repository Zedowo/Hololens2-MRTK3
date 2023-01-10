using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        while (true)
        {
            Debug.Log("First Print");
            yield return new WaitForSeconds(20);
            Debug.Log("Second Print");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
