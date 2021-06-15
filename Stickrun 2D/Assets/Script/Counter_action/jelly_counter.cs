using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jelly_counter : MonoBehaviour
{
    Text text;
    public static int jelly_amount;
    void Start()
    {
        text = GetComponent<Text>();
        jelly_amount = PlayerPrefs.GetInt("jelly");
    }

    // Update is called once per frame
    void Update()
    {
        text.text = jelly_amount.ToString();
        PlayerPrefs.SetInt("jelly", jelly_amount);
        //PlayerPrefs.DeleteAll();
    }
}
