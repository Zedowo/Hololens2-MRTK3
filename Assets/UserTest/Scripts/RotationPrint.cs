using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPrint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void RotateByDegrees(float degree)
    {
        //degree = degree * temp;
        //degree = degree / 2;
        degree = degree * -1;
        Vector3 rotationToAdd = new Vector3(0, degree, 0);
        transform.Rotate(rotationToAdd);
        //transform.localRotation = Quaternion.Euler(rotationToAdd);
        //transform.eulerAngles = rotationToAdd;
    }

    // Update is called once per frame
    void Update()
    {


    }
}