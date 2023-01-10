using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftTurnSignal : MonoBehaviour
{
    private GameplayManager gamePlayManager;
    private int value = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.z < -90)
        {
            Debug.Log("Turn!");
        }
    }
}
