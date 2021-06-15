using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_game : MonoBehaviour
{ 
    public string scene_menu;    //Dont forget to input scene name in inspector
    public GameObject pause_pannel;

    public void PauseButtonClick()
    {
        Time.timeScale = 0;
        pause_pannel.SetActive(true);
    }

    public void ResumeButtonClick()
    {
        Time.timeScale = 1;
        pause_pannel.SetActive(false);
    }

    public void RuturntoMEnuButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(scene_menu);
    }
}
