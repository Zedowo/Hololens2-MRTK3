using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideScript : MonoBehaviour
{
    public int bump = 1;
    public int lanepass = 1;

    private GameplayManager gamePlayManager;

    private void Awake()
    {
        gamePlayManager = GameObject.FindObjectOfType<GameplayManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sidewalk" || collision.gameObject.tag == "Vehicle")
        {
            gamePlayManager.UpdateScore(bump);
        }
        else if (collision.gameObject.tag == "Lanemarker")
        {
            //Add code here for switching lanes while passing, or when some lanemarkers are meant to be crossed
            gamePlayManager.UpdateLane(lanepass);
        }
        else
        {
            return;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
