using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideScript : MonoBehaviour
{
    public int bump = 1;
    public int lanepass = 1;
    private GameplayManager gamepLayManager;

    private void Awake()
    {
        gamepLayManager = GameObject.FindObjectOfType<GameplayManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Road")
        {
            return;
        }
        else if(collision.gameObject.name == "CrossOver")
        {
            return;
        }
        else if (collision.gameObject.name == "CenterLane")
        {
            gamepLayManager.UpdateLane(lanepass);
        }
        else
        {
            gamepLayManager.UpdateScore(bump);
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
