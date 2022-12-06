using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reloadScene()
    {
        SceneManager.LoadScene("P_Environment");
    }
    public void homeScene()
    {
        SceneManager.LoadScene("P_StartScene");
    }
    public void quitApp()
    {
        Application.Quit();
    }
}
