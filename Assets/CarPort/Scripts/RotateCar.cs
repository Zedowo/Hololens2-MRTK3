using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void RotateByDegrees(float degree)
    {
        Vector3 rotationToAdd = new Vector3(0, degree, 0);
        transform.Rotate(rotationToAdd);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
