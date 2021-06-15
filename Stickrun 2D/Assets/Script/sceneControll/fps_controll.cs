using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps_controll : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 50;
    }
}
