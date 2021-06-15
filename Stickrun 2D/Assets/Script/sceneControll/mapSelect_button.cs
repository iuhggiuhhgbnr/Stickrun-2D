using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapSelect_button : MonoBehaviour
{
    public GameObject MapSelectPanel;

    public void MapselectButtonActive()
    {
        MapSelectPanel.SetActive(true);
    }

    public void MapCloseButtonActive()
    {
        MapSelectPanel.SetActive(false);
    }
}
