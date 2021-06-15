using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class jelly_col_player : MonoBehaviour
{

    public AudioSource pickupsound;

   
    void OnTriggerEnter2D(Collider2D col)
    {
        AnalyticsResult analyticsResult = Analytics.CustomEvent("jelly_pick" + 1);
        pickupsound.Play();
        jelly_counter.jelly_amount += 1;
        Destroy(gameObject);
    }
}
