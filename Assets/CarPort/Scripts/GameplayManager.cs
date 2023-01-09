using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public Text scoreText;
    private int currentScore;
    public Text laneText;
    private int currentScore2;
    public Text speedText;
    private int currentSpeed;


    public void UpdateScore(int score)
    {
        currentScore += score;
        scoreText.text = "Collisions: " + currentScore.ToString();
    }

    public void UpdateLane(int score)
    {
        currentScore2 += score;
        laneText.text = "Crosses: " + currentScore2.ToString();
    }
    public void UpdateSpeed(int speed) {
        //currentSpeed = (Rigidbody X Axis Speed + Z Axis Speed)/2 == Average speed across X and Z Axis?
        //speedText.text = "Speed: " + currentSpeed.ToString();
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



