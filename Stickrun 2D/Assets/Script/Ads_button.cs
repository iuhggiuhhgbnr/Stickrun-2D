using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class Ads_button : MonoBehaviour , IUnityAdsListener
{
    public Text getcoin_text;
    public GameObject AdsButton_show;
    public int coin_getting_AdsEdit = 0;
    string gameId = "3858177";
    bool testMode = false;
    string placementId = "rewardedVideo";
    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);
        getcoin_text.text = coin_getting_AdsEdit.ToString();
    }

    public void On_Ads_ButtonActive(string p)
    {
        Advertisement.Show(p);
    }

    public void OnUnityAdsDidError(string message)
    {
        AdsButton_show.SetActive(false);
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
     if(showResult == ShowResult.Finished)
        {
            jelly_counter.jelly_amount += coin_getting_AdsEdit;
        }
     else if (showResult == ShowResult.Failed)
        {
            jelly_counter.jelly_amount += 0;
        }
     else if(showResult == ShowResult.Skipped)
        {
            jelly_counter.jelly_amount += 0;
        }
    }

    public void OnUnityAdsDidStart(string placementId)
    {

    }

    public void OnUnityAdsReady(string placementId)
    {
        AdsButton_show.SetActive(true);
    }


}
