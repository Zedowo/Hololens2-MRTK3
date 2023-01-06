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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}



