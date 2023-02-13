using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class InstAdManager : MonoBehaviour
{
    int scene;
    private InterstitialAd interstitial;
    bool check;

    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(initStatus => { });

            RequestInterstitial();
            //interstitial.Show();
    }

    private void RequestInterstitial()
    {
        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-9214006915655070/3583551041";
        #else
                string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }

    void Update()
    {
        if (!check)
        {
            if (interstitial.IsLoaded())
            {
                interstitial.Show();
                check = true;
            }
        }
    }

}




/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class InstAdManager : MonoBehaviour
{
    private InterstitialAd interstitial;

    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(initstatus => { });
        RequestInterstitial();

        if(interstitial.IsLoaded()) {
            interstitial.Show();
        }
    }

    private void RequestInterstitial()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-9214006915655070/3583551041";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-9214006915655070/3583551041";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }
}*/
