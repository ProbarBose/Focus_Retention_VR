using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final_Score : MonoBehaviour
{
    public Scoring_System score;
    public Text finalScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        finalScore.text = "" + score;
    }

    // Update is called once per frame
    
}
