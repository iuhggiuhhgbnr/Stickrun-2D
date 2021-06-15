using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dead_check : MonoBehaviour
{
    public int Coin_require_retry = 0;
    public Text Coin_require_text;
    public GameObject Disable_player_whenTrigger;
    public GameObject DeadPanel_showUP;
    public float x_respawn, y_respawn, z_respawn;                           //set spawnpoint when respawn is active
    void OnTriggerEnter2D(Collider2D col)
    {
        Disable_player_whenTrigger.SetActive(false);
        DeadPanel_showUP.SetActive(true);
        //jelly_counter.jelly_amount = 0;
        //SceneManager.LoadScene(0);
    }


   public void TryAgainButtonClick()          //make it public to let button can use it
    {
        if (jelly_counter.jelly_amount >= Coin_require_retry)
        {
            jelly_counter.jelly_amount -= Coin_require_retry;
            Disable_player_whenTrigger.transform.position = new Vector3(x_respawn, y_respawn, z_respawn);
            Disable_player_whenTrigger.SetActive(true);    //if press button and it active  the player respawn
            DeadPanel_showUP.SetActive(false);             //Dead panel is now hide
        }
        else
            return;
  
    }

    void Start()
    {
        Coin_require_text.text = Coin_require_retry.ToString();
    }
}
