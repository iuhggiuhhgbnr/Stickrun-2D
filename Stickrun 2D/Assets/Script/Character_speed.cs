using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_speed : MonoBehaviour
{
    [SerializeField]
    public float setspeed;

    [SerializeField]
    public float setjump_high;

    public static float brav_speed;
    public static float brav_jump;

    //Character_speed.brav_jump
    //Character_speed.brav_speed
    void Start()
    {
        brav_speed = setspeed;
        brav_jump = setjump_high;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
