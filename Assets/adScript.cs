using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using GooglePlayGames.BasicApi;
using GooglePlayGames;

public class adScript : MonoBehaviour {
    private const string Ad_Unit_ID = "ca-app-pub-9499257650407538/3572719604";
    private const string Ad_Intertitial_ID = "ca-app-pub-9499257650407538/9340051606";

    private const string Unity_ID = "53943";

    private AdMobPlugin admob;
	// Use this for initialization
    void Awake()
    {


   
        if (Advertisement.isSupported)
        {

           
            Advertisement.Initialize(Unity_ID, false);
        }
      
        admob = GetComponent<AdMobPlugin>();
        admob.CreateBanner(Ad_Unit_ID, AdMobPlugin.AdSize.SMART_BANNER, false, Ad_Intertitial_ID, false);//, Ad_Intertitial_ID
        admob.RequestAd();
    }
	
    public void OnEnable()
    {


        AdMobPlugin.InterstitialLoaded += HandleInterstitialLoaded;
    }
    public void OnDisable()
    {


        AdMobPlugin.InterstitialLoaded -= HandleInterstitialLoaded;
        
        
    }

    public void HandleInterstitialLoaded()
    {
      
        admob.ShowInterstitial();

      
    }
    void Update()
    {

        if (PauseMenuNavigation.paused || playerController.over)
        {
            admob.ShowBanner();

        }
        if (!PauseMenuNavigation.paused && !playerController.over)
        {
            admob.HideBanner();

        }


        if (playerController.Dead && PlayerPrefs.GetInt("NumberOfDeath", 0) == 5 && playerController.over)
        {

           admob.RequestInterstitial();

           
            

            playerController.Dead = false;
        }
        if (playerController.Dead && PlayerPrefs.GetInt("NumberOfDeath", 0) == 12 && playerController.over)
        {


            
              Advertisement.Show(

                   null, new ShowOptions {
                       resultCallback = result =>
                       {

                       }
                   });

            PlayerPrefs.SetInt("NumberOfDeath", 0);
            playerController.Dead = false;
        }
        
        if (PauseMenuNavigation.mainmenu)
        {

            //admob.HideBanner();

        }
        if (!PauseMenuNavigation.mainmenu)
        {


           

        }
    }
	

}
