using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoops_Score : MonoBehaviour
{
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
        score.AddScore(10);
    }
}
