using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSignalPrintR: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.rotation.z * -1) > 90)
        {
            Debug.Log("Turn!");
        }
    }
}
