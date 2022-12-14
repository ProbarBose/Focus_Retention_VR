using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoops_Score_Pink : MonoBehaviour
{
    public AudioSource positive;
    public AudioSource negative;
    public Scoring_System score;

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
        if (other.CompareTag("Pink"))
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
