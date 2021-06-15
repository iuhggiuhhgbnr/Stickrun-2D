using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_button : MonoBehaviour
{
    public string scene_to_go1;

    public void StartGameButtonCick()          //make it public to let button can use it
    {
        SceneManager.LoadScene(scene_to_go1);   
    }


    public void ExitGameButtonClick()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }
}
