using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DisCAM_finish : MonoBehaviour
{
    public GameObject target_enable;
    void OnTriggerEnter2D(Collider2D col)
    {
        target_enable.SetActive(true);
    }
}
