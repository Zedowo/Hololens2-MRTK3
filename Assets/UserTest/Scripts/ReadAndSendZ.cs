using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadAndSendZ : MonoBehaviour
{
    public RotationPrint rotate;
    // Start is called before the first frame update

    private void Awake()
    {
        rotate = GameObject.FindObjectOfType<RotationPrint>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotate.RotateByDegrees(transform.rotation.z);
    }
}
