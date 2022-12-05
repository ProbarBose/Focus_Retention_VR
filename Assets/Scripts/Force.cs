using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public Rigidbody Sphere;
    void Start()
    {
        Sphere.AddForce(-transform.forward * 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
