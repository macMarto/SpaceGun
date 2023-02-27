using UnityEngine;
using UnityEngine.Advertisements;

public class ads : MonoBehaviour
{
    string googlePlay_ID = "4122807";
private string InterstitialID = "Interstitial_Android";
    static int loadCount = 0;
    bool testMode = false;
    void Start()
    {
        Advertisement.Initialize(googlePlay_ID, testMode);
        if (loadCount % 2 == 0)
        {
            ShowInterstitialAd();
        }
        loadCount++;
    }

    public void ShowInterstitialAd()
    {
        if (Advertisement.IsReady(InterstitialID))
        {
            Advertisement.Show(InterstitialID);
        }
    }

}
