using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class obstack_hit : MonoBehaviour
{
    public GameObject Disable_player_whenTrigger;
    public GameObject DeadPanel_showUP;
    void OnTriggerEnter2D(Collider2D col)
    {
        Disable_player_whenTrigger.SetActive(false);
        DeadPanel_showUP.SetActive(true);
    }
}
