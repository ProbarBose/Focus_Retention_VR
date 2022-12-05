using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring_System : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public int maxScore;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
    public void AddScore(int newScore)
    {
        score = score + newScore;
    }
    public void SubtractScore(int newScore)
    {
        score = score - newScore;
    }
    public void UpdateScore()
    {
        scoreText.text = "0" + score;
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
    }
}
