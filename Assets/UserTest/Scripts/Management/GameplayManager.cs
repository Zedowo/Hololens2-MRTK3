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
    private bool leftSignalOn = false;
    private bool rightSignalOn = false;

    public Text speedText;
    private float currentSpeed;
    public float UpdateDelay = 5;

    public void UpdateScore(int score) // Does not increment digits above 10 (?)
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

    public void updateLeftSignal(int value) // This makes it so you can only change the signal when the other turn signal is off. This works as intended, except when the blinker gets switched while
    {                                       // the other turn signal is in the middle of its blink. This can be fixed once the wheel resets position. The signal stick can just reset its z rotation.
        if (value == 1 && !rightSignalOn)
        {
            leftSignalOn = true;
            blinkTextLeft.text  = "<--";
        }
        else 
        {
            leftSignalOn = false;
            blinkTextLeft.text = " ";
        }
    }

    public void updateRightSignal(int value)
    {
        if (value == 1 && !leftSignalOn) // This makes it so you can only change the signal when the other turn signal is off. This works as intended, except when the blinker gets switched while
                                         // the other turn signal is in the middle of its blink. This can be fixed once the wheel resets position. The signal stick can just reset its z rotation.
        {
            rightSignalOn = true;
            blinkTextRight.text = "-->";
        }
        else
        {
            rightSignalOn = false;
            blinkTextRight.text = " ";
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



