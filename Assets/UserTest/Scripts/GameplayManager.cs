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

    public Text blinkTextRight;
    public Text blinkTextLeft;

    public Text speedText;
    private float currentSpeed;
    public float UpdateDelay = 5;

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
    public void UpdateSpeed(float speed) {
        //currentSpeed = (Rigidbody X Axis Speed + Z Axis Speed)/2 == Average speed across X and Z Axis?
        //speedText.text = "Speed: " + currentSpeed.ToString();
    }

    public void updateLeftSignal(int value)
    {
        if (value == 1)
        {
            blinkTextLeft.text  = "<--";
        }
        else 
        {
            blinkTextLeft.text = " ";
        }
    }

    public void updateRightSignal(int value)
    {
        if (value == 0)
        {
            blinkTextRight.text = "-->";
        }
        else
        {
            blinkTextLeft.text = " ";
        }
    }

    /*void OnEnabled()
    {
        StartCoroutine(SpeedCalculation()); //starts speed calculation routine
    }

    private IEnumerator SpeedCalculation()
    {

        YieldInstruction timedWait = new WaitForSeconds(UpdateDelay); //creates a yield instruction that pauses the function for UpdateDelay time
        Vector3 lastPosition = transform.position; //current position
        float lastTimestamp = Time.time; //the time at the beginning of the current frame

        while (enabled)
        {
            yield return timedWait; 

            var deltaPosition = (transform.position - lastPosition).magnitude; //grabs the distance between the two positions
            var deltaTime = Time.time - lastTimestamp; //var --> Variables whose types are dependent on its usage

            if (Mathf.Approximately(deltaPosition, 0f)) // Clean up "near-zero" displacement
                deltaPosition = 0f;

            currentSpeed = deltaPosition / deltaTime; //actual speed calculation

            lastPosition = transform.position; //resets position
            lastTimestamp = Time.time; //resets time
        }
        UpdateSpeed(currentSpeed); //might need to change position of method
    }*/


    // Start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}



