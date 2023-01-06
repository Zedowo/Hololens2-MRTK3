using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToInt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string testString = "4";
        int x = Int32.Parse(testString);
        Debug.Log(x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
