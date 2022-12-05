using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject SpawnSet01;
    public GameObject SpawnSet02;
    public GameObject SpawnSet03;
    public GameObject SpawnSet04;
    public GameObject SpawnSet05;
    public GameObject SpawnSet06;
    public GameObject SpawnSet07;
    public GameObject SpawnSet08;
    public GameObject SpawnSet09;
    public GameObject SpawnSet10;

    public GameObject DisplaySet01;
    public GameObject DisplaySet02;
    public GameObject DisplaySet03;
    public GameObject DisplaySet04;
    public GameObject DisplaySet05;
    public GameObject DisplaySet06;
    public GameObject DisplaySet07;
    public GameObject DisplaySet08;
    public GameObject DisplaySet09;
    public GameObject DisplaySet10;

    public GameObject HoopSet01;
    public GameObject HoopSet02;
    public GameObject HoopSet03;
    public GameObject HoopSet04;
    public GameObject HoopSet05;
    public GameObject HoopSet06;
    public GameObject HoopSet07;
    public GameObject HoopSet08;
    public GameObject HoopSet09;
    public GameObject HoopSet10;

    public GameObject End_Screen;

    public GameObject directHandR;
    public GameObject directHandL;
    public GameObject rayHandL;
    public GameObject rayHandR;
    
    private void Start()
    {
        StartCoroutine(fireShapes());
    }

    IEnumerator fireShapes()
    {
        fire01();
        yield return new WaitForSeconds(12f);
        Destroy(SpawnSet01);
        Destroy(DisplaySet01);
        Destroy(HoopSet01);
        fire02();
        yield return new WaitForSeconds(12f);
        Destroy(SpawnSet02);
        Destroy(DisplaySet02);
        Destroy(HoopSet02);
        fire03();
        yield return new WaitForSeconds(12f);
        Destroy(SpawnSet03);
        Destroy(DisplaySet03);
        Destroy(HoopSet03);
        fire04();
        yield return new WaitForSeconds(12f);
        Destroy(SpawnSet04);
        Destroy(DisplaySet04);
        Destroy(HoopSet04);
        fire05();
        yield return new WaitForSeconds(12f);
        Destroy(SpawnSet05);
        Destroy(DisplaySet05);
        Destroy(HoopSet05);
        fire06();
        yield return new WaitForSeconds(12f);
        Destroy(SpawnSet06);
        Destroy(DisplaySet06);
        Destroy(HoopSet06);
        fire07();
        yield return new WaitForSeconds(12f);
        Destroy(SpawnSet07);
        Destroy(DisplaySet07);
        Destroy(HoopSet07);
        fire08();
        yield return new WaitForSeconds(12f);
        Destroy(SpawnSet08);
        Destroy(DisplaySet08);
        Destroy(HoopSet08);
        fire09();
        yield return new WaitForSeconds(12f);
        Destroy(SpawnSet09);
        Destroy(DisplaySet09);
        Destroy(HoopSet09);
        fire10();
        yield return new WaitForSeconds(12f);
        Destroy(SpawnSet10);
        Destroy(DisplaySet10);
        Destroy(HoopSet10);
        yield return new WaitForSeconds(4f);
        End_Screen.SetActive(true);
        directHandR.SetActive(false);
        directHandL.SetActive(false);
        rayHandL.SetActive(true);
        rayHandR.SetActive(true);
    }

    public void fire01()
    {
        DisplaySet01.SetActive(true);
        SpawnSet01.SetActive(true);
        HoopSet01.SetActive(true);
        
    }
    public void fire02()
    {
        DisplaySet02.SetActive(true);
        SpawnSet02.SetActive(true);
        HoopSet02.SetActive(true);

    }

    public void fire03()
    {
        DisplaySet03.SetActive(true);
        SpawnSet03.SetActive(true);
        HoopSet03.SetActive(true);

    }

    public void fire04()
    {
        DisplaySet04.SetActive(true);
        SpawnSet04.SetActive(true);
        HoopSet04.SetActive(true);

    }

    public void fire05()
    {
        DisplaySet05.SetActive(true);
        SpawnSet05.SetActive(true);
        HoopSet05.SetActive(true);

    }

    public void fire06()
    {
        DisplaySet06.SetActive(true);
        SpawnSet06.SetActive(true);
        HoopSet06.SetActive(true);

    }

    public void fire07()
    {
        DisplaySet07.SetActive(true);
        SpawnSet07.SetActive(true);
        HoopSet07.SetActive(true);

    }

    public void fire08()
    {
        DisplaySet08.SetActive(true);
        SpawnSet08.SetActive(true);
        HoopSet08.SetActive(true);

    }

    public void fire09()
    {
        DisplaySet09.SetActive(true);
        SpawnSet09.SetActive(true);
        HoopSet09.SetActive(true);

    }

    public void fire10()
    {
        DisplaySet10.SetActive(true);
        SpawnSet10.SetActive(true);
        HoopSet10.SetActive(true);

    }

}
