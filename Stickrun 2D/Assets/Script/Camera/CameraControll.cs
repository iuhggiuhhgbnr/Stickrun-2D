using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraControll : MonoBehaviour
{
    public AudioSource backgroundsound;
    public GameObject playerCAM, finishCAM;
    public CinemachineBrain cinemachine;
    void Start()
    {
        Character_speed.brav_speed = 0f;
        Character_speed.brav_jump = 0f;
        playerCAM.SetActive(false);
        finishCAM.SetActive(true);
        StartCoroutine(FinishToPlayerCam());
    }

    IEnumerator FinishToPlayerCam()
    {
        yield return new WaitForSeconds(2);
        playerCAM.SetActive(true);
        finishCAM.SetActive(false);
        yield return new WaitForSeconds(10);
        backgroundsound.Play();
        Character_speed.brav_speed = 10f;
        Character_speed.brav_jump = 950f;
    }


    }
