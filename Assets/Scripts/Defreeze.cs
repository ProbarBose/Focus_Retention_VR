using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defreeze : MonoBehaviour
{
    public GameObject sphere01;
    public void deFreeze()
    {
        sphere01.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}
