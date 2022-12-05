using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject planeSet01;
    //public GameObject planeSet02;
    //public GameObject ballPrefab;
    //public GameObject[] set01;
    //public GameObject[] set02;
    //public GameObject[] prefabShapes;
    //private IEnumerator fireShapes;

    //public Transform ballFire;
    //public float ballForce;

    private void Start()
    {
        StartCoroutine(fireShapes());
    }

    IEnumerator fireShapes()
    {
        fire01();
        yield return new WaitForSeconds(3f);
        //fire02();

    }

    public void fire01()
    {
        //Instantiate(planeSet01, new Vector3(0, 0, 0), Quaternion.identity);
        //prefabShapes = new GameObject[set01.Length];
        //for (int i = 0; i < set01.Length; i++)
        //{
        //   prefabShapes[i] = Instantiate(set01[i]) as GameObject;
        //}
        
        //int n = instantiatedShapes.Length;
        //GameObject multiBall = Instantiate(instantiatedShapes[n]);
        //Rigidbody rb = multiBall.GetComponent<Rigidbody>();
        //rb.AddForce(ballFire.forward * ballForce, ForceMode.Impulse);
        //Destroy(multiBall, 3f);
    }
    public void fire02()
    {
        //Instantiate(planeSet01, new Vector3(0, 0, 0), Quaternion.identity);
        /*prefabShapes = new GameObject[set02.Length];
        for (int i = 0; i < set02.Length; i++)
        {
            prefabShapes[i] = Instantiate(set02[i]) as GameObject;
        }*/
    }

}
