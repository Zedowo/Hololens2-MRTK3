using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LeftTurnSignal : MonoBehaviour
{
    private GameplayManager gamePlayManager;
    //private int value = 0;

    //public GameObject leftTurnText;
    //public GameObject leftTurnStick = GameObject.FindWithTag("TurnSignal");

    // Start is called before the first frame update
    void Start()
    {
        //Green Colors is 95 210 20 255, Hex is 5FD214
        gamePlayManager = GameObject.FindObjectOfType<GameplayManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.z >= 0) { //rotation of turn signal at which it is considered "On"
            //leftTurnText.SetActive(true);
            Debug.Log("Turn!");
            gamePlayManager.updateLeftSignal(1);
        }
        else {
            //leftTurnText.SetActive(false);
            gamePlayManager.updateLeftSignal(0);
        }
    }
}
