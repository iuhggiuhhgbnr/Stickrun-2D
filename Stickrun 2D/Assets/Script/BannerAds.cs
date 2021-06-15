using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAds : MonoBehaviour
{
    string gameId = "3858177";
    string placementId = "cookie_banner";
    bool testMode = false;

    IEnumerator Start()
    {
        Advertisement.Initialize(gameId, testMode);

        while (!Advertisement.IsReady(placementId))
            yield return null;

        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);  //show banner posi ต้องมาก่อน show
        Advertisement.Banner.Show(placementId);
        
    }
}
