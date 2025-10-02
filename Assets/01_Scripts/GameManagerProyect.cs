using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManagerProyect : MonoBehaviour
{
    public BallController ball;
    public Text scoreText;
    private int scoreLeft = 0, scoreRight = 0;

    public void GoalLeft()
    {
        scoreRight++;
        UpdateScore();
        ball.ResetBall();
    }

    public void GoalRight()
    {
        scoreLeft++;
        UpdateScore();
        ball.ResetBall();
    }

    void UpdateScore()
    {
        scoreText.text = scoreLeft + " - " + scoreRight;
    }
}
