using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyShapes : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Working");
        //Destroy(GameObject.FindWithTag("Shapes"));
        Destroy(other.gameObject);
    }
}
