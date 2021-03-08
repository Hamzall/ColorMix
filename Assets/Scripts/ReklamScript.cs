using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class ReklamScript : MonoBehaviour
{
    private RewardedAd rewardedAd;
    private BannerView reklam;
    private InterstitialAd Gecisli;
    public string BannerID = "ca-app-pub-1861985485714004/1283907024";
    public string Gecis = "ca-app-pub-1861985485714004/4078140065";
    public string Odullu = "ca-app-pub-1861985485714004/3221429367";

    // Start is called before the first frame update
    void Start()
    {
        
        MobileAds.Initialize(reklamver => { });
       // BannerReklam();
        GecisReklam();
    }

   public void BannerReklam()
    {
        reklam = new BannerView(BannerID, AdSize.SmartBanner, AdPosition.Top);
        AdRequest adRequest = new AdRequest.Builder().Build();
        reklam.LoadAd(adRequest);
    }
    public void GecisReklam()
    {
        Gecisli = new InterstitialAd(Gecis);
        AdRequest adRequest = new AdRequest.Builder().Build();
        Gecisli.LoadAd(adRequest);
        
    }
    public void OdulluReklam()
    {
        rewardedAd = new RewardedAd(Odullu);
        AdRequest request = new AdRequest.Builder().Build();
        
        this.rewardedAd.LoadAd(request);

    }
    public void GecisliReklamGoster()
    {
        if (Gecisli.IsLoaded())
        {
            Gecisli.Show();
        }

    }
}
