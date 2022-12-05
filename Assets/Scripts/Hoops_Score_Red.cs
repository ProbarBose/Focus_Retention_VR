using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoops_Score_Red : MonoBehaviour
{
    public Scoring_System score;
    public AudioSource positive;
    public AudioSource negative;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red"))
        {
            score.AddScore(10);
            positive.Play();

        }
        else
        {
            score.SubtractScore(5);
            negative.Play();
        }
    }
}
