using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCarByOne : MonoBehaviour
{
    public int movementint = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 deltaPosition = new Vector3(
        Input.GetAxis("Horizontal"),
        Input.GetAxis("Jump"),
        Input.GetAxis("Vertical")
        ) * Time.deltaTime * movementint;
        transform.Translate(deltaPosition);
    }
}
