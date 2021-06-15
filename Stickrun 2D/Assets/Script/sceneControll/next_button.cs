using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class next_button : MonoBehaviour
{
    public string NextState_Input;

    public void OnNextStageButtonClick()
    {
        SceneManager.LoadScene(NextState_Input);
    }
}
