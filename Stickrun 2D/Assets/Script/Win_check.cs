using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win_check : MonoBehaviour
{
    public GameObject Disable_player_whenTrigger;
    public GameObject WinPanel_showUP;
    void OnTriggerEnter2D(Collider2D col)
    {
        Disable_player_whenTrigger.SetActive(false);
        WinPanel_showUP.SetActive(true);
        //jelly_counter.jelly_amount = 0;
        //SceneManager.LoadScene(0);
    }
}
