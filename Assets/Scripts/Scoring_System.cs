using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring_System : MonoBehaviour
{
    public Text scoreText;
    public Text finalScore;
    public Text focus;
    public int score = 0;
    public int maxScore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
    public void AddScore(int addScore)
    {
        score = score + addScore;
    }
    public void SubtractScore(int subScore)
    {
        score = score - subScore;
    }
    public void UpdateScore()
    {
        scoreText.text = "" + score;
        finalScore.text = "" + score;
    }

    public void OnGrabAddScore()
    {
        AddScore(10);
    }
    public void OnGrabMinus()
    {
        SubtractScore(10);
    }

    void Update()
    {
        UpdateScore();
        focusRetention();
    }
    public void focusRetention()
    {
        if (score <= 200 && score >= 150)
        {
            focus.text = "High";
        }
        else if (score < 150 && score >= 70)
        {
            focus.text = "Moderate";
        }
        else
        {
            focus.text = "Low";
        }
    }
}
