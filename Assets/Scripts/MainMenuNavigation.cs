using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using System;
public class MainMenuNavigation : MonoBehaviour {
    public AudioClip clicSound;
 public   bool music =true;
 public   bool sound = true;
 public GameObject SoundButton;
 public GameObject MusicButton;
 public GameObject Music;
 public GameObject Sound;
 public Sprite SoundOffSprite;
 public Sprite SoundOnSprite;
 public Sprite MusicOffSprite;
 public Sprite MusicOnSprite;
    int SoundIndex=1;
    int MusicIndex=1;

   public bool quitvisible = false;
    public GameObject QuitMenu;
    public GameObject canvasMenu;
    public GameObject BigCanvas;
 public static   bool about = false;

 public static bool store = false;

    public GameObject AboutPanel;
    public GameObject LeftButton;
    public GameObject RightButton;
    public GameObject MainButton;
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Message1;
    public GameObject Message2;
    public GameObject StorePanel;
    public GameObject Pack1;
    public GameObject Loly1Selected;
    public GameObject Loly1Unselected;
    public GameObject Loly2Locked;
    public GameObject Loly2Selected;
    public GameObject Loly2Unselected;
    public GameObject Loly3Locked;
    public GameObject Loly3Selected;
    public GameObject Loly3Unselected;
    public GameObject Loly4Locked;
    public GameObject Loly4Selected;
    public GameObject Loly4Unselected;
    public GameObject Loly5Locked;
    public GameObject Loly5Selected;
    public GameObject Loly5Unselected;
    public GameObject Loly6Locked;
    public GameObject Loly6Selected;
    public GameObject Loly6Unselected;
    public GameObject Loly7Locked;
    public GameObject Loly7Selected;
    public GameObject Loly7Unselected;
    public GameObject Loly8Locked;
    public GameObject Loly8Selected;
    public GameObject Loly8Unselected;
    public GameObject Loly9Locked;
    public GameObject Loly9Selected;
    public GameObject Loly9Unselected;
    public GameObject Loly10Locked;
    public GameObject Loly10Selected;
    public GameObject Loly10Unselected;
    public GameObject Loly11Locked;
    public GameObject Loly11Selected;
    public GameObject Loly11Unselected;
    public GameObject Loly12Locked;
    public GameObject Loly12Selected;
    public GameObject Loly12Unselected;
    public GameObject Loly13Locked;
    public GameObject Loly13Selected;
    public GameObject Loly13Unselected;
    public GameObject Loly14Locked;
    public GameObject Loly14Selected;
    public GameObject Loly14Unselected;
    public GameObject Loly15Locked;
    public GameObject Loly15Selected;
    public GameObject Loly15Unselected;
    public GameObject Loly16Locked;
    public GameObject Loly16Selected;
    public GameObject Loly16Unselected;
    public GameObject Loly17Locked;
    public GameObject Loly17Selected;
    public GameObject Loly17Unselected;
    public GameObject Loly18Locked;
    public GameObject Loly18Selected;
    public GameObject Loly18Unselected;
    public GameObject Loly19Locked;
    public GameObject Loly19Selected;
    public GameObject Loly19Unselected;
    public GameObject Loly20Locked;
    public GameObject Loly20Selected;
    public GameObject Loly20Unselected;
    public GameObject Loly21Locked;
    public GameObject Loly21Selected;
    public GameObject Loly21Unselected;
    public GameObject Loly22Locked;
    public GameObject Loly22Selected;
    public GameObject Loly22Unselected;
    public GameObject Loly23Locked;
    public GameObject Loly23Selected;
    public GameObject Loly23Unselected;
    public GameObject Loly24Locked;
    public GameObject Loly24Selected;
    public GameObject Loly24Unselected;
    public GameObject MainMenuScore;

    public GameObject Pack2;
    public GameObject Pack3;
    public GameObject RightButtonStore;
    public GameObject LeftButtonStore;
    public GameObject MainButtonStore;
    public GameObject Title;
    int SkinSelected;
    int Unlocked2;
    int Unlocked3; 
    int Unlocked4; 
    int Unlocked5; 
    int Unlocked6; 
    int Unlocked7;
    int Unlocked8;
    int Unlocked9;
    int Unlocked10;
    int Unlocked11;
    int Unlocked12;
    int Unlocked13;
    int Unlocked14;
    int Unlocked15;
    int Unlocked16;
    int Unlocked17;
    int Unlocked18;
    int Unlocked19;
    int Unlocked20;
    int Unlocked21;
    int Unlocked22;
    int Unlocked23;
    int Unlocked24;
    int Total_nb_candy;
    int pos2;
    public static bool playClicked;
 //SoundSource.playOnAwake = false; //SoundSource.rolloffMode = AudioRolloffMode.Logarithmic; //SoundSource.loop = true; }


    void Start()
    {
     
        PlayGamesPlatform.Activate();
        
        Social.localUser.Authenticate((bool success) =>
        {
            // handle success or failure
           
        });
      
        pos2 = 1;
        quitvisible = false;
        about = false;
        store = false;
        playClicked = false;
              
    }

   
   

    void Update()
    {

        if (PlayerPrefs.GetInt("UnlockedSkins", 0) == 7)
        {
            Social.ReportProgress("CgkIy9_U8-4JEAIQCA", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }
        if (PlayerPrefs.GetInt("UnlockedSkins", 0) == 15)
        {
            Social.ReportProgress("CgkIy9_U8-4JEAIQCQ", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }
        if (PlayerPrefs.GetInt("UnlockedSkins", 0) == 23)
        {
            Social.ReportProgress("CgkIy9_U8-4JEAIQCg", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }
        Total_nb_candy = PlayerPrefs.GetInt("Total_Candy", 0);
         SkinSelected =  PlayerPrefs.GetInt("SkinSelected",1);
        Unlocked2 = PlayerPrefs.GetInt("Loly2lock", 0);
        Unlocked3 = PlayerPrefs.GetInt("Loly3lock", 0);
        Unlocked4 = PlayerPrefs.GetInt("Loly4lock", 0);
        Unlocked5 = PlayerPrefs.GetInt("Loly5lock", 0);
        Unlocked6 = PlayerPrefs.GetInt("Loly6lock", 0);
        Unlocked7 = PlayerPrefs.GetInt("Loly7lock", 0);
        Unlocked8 = PlayerPrefs.GetInt("Loly8lock", 0);
        Unlocked9 = PlayerPrefs.GetInt("Loly9lock", 0);
        Unlocked10 = PlayerPrefs.GetInt("Loly10lock", 0);
        Unlocked11 = PlayerPrefs.GetInt("Loly11lock", 0);
        Unlocked12 = PlayerPrefs.GetInt("Loly12lock", 0);
        Unlocked13 = PlayerPrefs.GetInt("Loly13lock", 0);
        Unlocked14 = PlayerPrefs.GetInt("Loly14lock", 0);
        Unlocked15 = PlayerPrefs.GetInt("Loly15lock", 0);
        Unlocked16 = PlayerPrefs.GetInt("Loly16lock", 0);
        Unlocked17 = PlayerPrefs.GetInt("Loly17lock", 0);
        Unlocked18 = PlayerPrefs.GetInt("Loly18lock", 0);
        Unlocked19 = PlayerPrefs.GetInt("Loly19lock", 0);
        Unlocked20 = PlayerPrefs.GetInt("Loly20lock", 0);
        Unlocked21 = PlayerPrefs.GetInt("Loly21lock", 0);
        Unlocked22 = PlayerPrefs.GetInt("Loly22lock", 0);
        Unlocked23 = PlayerPrefs.GetInt("Loly23lock", 0);
        Unlocked24 = PlayerPrefs.GetInt("Loly24lock", 0);

        if (Unlocked2 == 1)
        {
            Loly2Locked.SetActive(false);
        }
        else
        {
            Loly2Locked.SetActive(true);

        }
        if (Unlocked3 == 1)
        {
            Loly3Locked.SetActive(false);
        }
        else
        {
            Loly3Locked.SetActive(true);

        }
        if (Unlocked4 == 1)
        {
            Loly4Locked.SetActive(false);
        }
        else
        {
            Loly4Locked.SetActive(true);

        }
        if (Unlocked5 == 1)
        {
            Loly5Locked.SetActive(false);
        }
        else
        {
            Loly5Locked.SetActive(true);

        }
        if (Unlocked6 == 1)
        {
            Loly6Locked.SetActive(false);
        }
        else
        {
            Loly6Locked.SetActive(true);

        }
        if (Unlocked7 == 1)
        {
            Loly7Locked.SetActive(false);
        }
        else
        {
            Loly7Locked.SetActive(true);

        }
        if (Unlocked8 == 1)
        {
            Loly8Locked.SetActive(false);
        }
        else
        {
            Loly8Locked.SetActive(true);

        }
        if (Unlocked9 == 1)
        {
            Loly9Locked.SetActive(false);
        }
        else
        {
            Loly9Locked.SetActive(true);

        }
        if (Unlocked10 == 1)
        {
            Loly10Locked.SetActive(false);
        }
        else
        {
            Loly10Locked.SetActive(true);

        }
        if (Unlocked11 == 1)
        {
            Loly11Locked.SetActive(false);
        }
        else
        {
            Loly11Locked.SetActive(true);

        }
        if (Unlocked12 == 1)
        {
            Loly12Locked.SetActive(false);
        }
        else
        {
            Loly12Locked.SetActive(true);

        }
        if (Unlocked13 == 1)
        {
            Loly13Locked.SetActive(false);
        }
        else
        {
            Loly13Locked.SetActive(true);

        }
        if (Unlocked14 == 1)
        {
            Loly14Locked.SetActive(false);
        }
        else
        {
            Loly14Locked.SetActive(true);

        }
        if (Unlocked15 == 1)
        {
            Loly15Locked.SetActive(false);
        }
        else
        {
            Loly15Locked.SetActive(true);

        }
        if (Unlocked16 == 1)
        {
            Loly16Locked.SetActive(false);
        }
        else
        {
            Loly16Locked.SetActive(true);

        }
        if (Unlocked17 == 1)
        {
            Loly17Locked.SetActive(false);
        }
        else
        {
            Loly17Locked.SetActive(true);

        }
        if (Unlocked18 == 1)
        {
            Loly18Locked.SetActive(false);
        }
        else
        {
            Loly18Locked.SetActive(true);

        }
        if (Unlocked19 == 1)
        {
            Loly19Locked.SetActive(false);
        }
        else
        {
            Loly19Locked.SetActive(true);

        }
        if (Unlocked20 == 1)
        {
            Loly20Locked.SetActive(false);
        }
        else
        {
            Loly20Locked.SetActive(true);

        }
        if (Unlocked21 == 1)
        {
            Loly21Locked.SetActive(false);
        }
        else
        {
            Loly21Locked.SetActive(true);

        }
        if (Unlocked22 == 1)
        {
            Loly22Locked.SetActive(false);
        }
        else
        {
            Loly22Locked.SetActive(true);

        }
        if (Unlocked23 == 1)
        {
            Loly23Locked.SetActive(false);
        }
        else
        {
            Loly23Locked.SetActive(true);

        }
        if (Unlocked24 == 1)
        {
            Loly24Locked.SetActive(false);
        }
        else
        {
            Loly24Locked.SetActive(true);

        }

        switch (SkinSelected)
        {
            case 1:
                Loly1Selected.SetActive(true);
                Loly1Unselected.SetActive(false);
                if (Unlocked2 == 1)
                {
                  Loly2Selected.SetActive(false);
                  Loly2Unselected.SetActive(true);

                }
                if (Unlocked3 == 1)
                {
                    Loly3Selected.SetActive(false);
                    Loly3Unselected.SetActive(true);

                }
                if (Unlocked4 == 1)
                {
                    Loly4Selected.SetActive(false);
                    Loly4Unselected.SetActive(true);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Selected.SetActive(false);
                    Loly5Unselected.SetActive(true);

                }
                if (Unlocked6 == 1)
                {

                    Loly6Selected.SetActive(false);
                    Loly6Unselected.SetActive(true);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Selected.SetActive(false);
                    Loly7Unselected.SetActive(true);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Selected.SetActive(false);
                    Loly8Unselected.SetActive(true);

                }
                if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }


            break;
            case 2:
                
                if (Unlocked2 == 1)
                {
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly2Selected.SetActive(true);
                    Loly2Unselected.SetActive(false);

                }
                if (Unlocked3 == 1)
                {
                   
                  
                    Loly3Unselected.SetActive(true);
                    Loly3Selected.SetActive(false);

                }
                if (Unlocked4 == 1)
                {
                    Loly4Unselected.SetActive(true);
                    Loly4Selected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Unselected.SetActive(true);
                    Loly5Selected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly6Unselected.SetActive(true);
                    Loly6Selected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Unselected.SetActive(true);
                    Loly7Selected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Unselected.SetActive(true);
                    Loly8Selected.SetActive(false);

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }


            break;
            case 3:
                  if (Unlocked2 == 1)
                {
                    Loly2Unselected.SetActive(true);
                    Loly2Selected.SetActive(false);
             

                }
                if (Unlocked3 == 1)
                {
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly3Selected.SetActive(true);
                    Loly3Unselected.SetActive(false);
                  

                }
                if (Unlocked4 == 1)
                {
                    Loly4Unselected.SetActive(true);
                    Loly4Selected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Unselected.SetActive(true);
                    Loly5Selected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly6Unselected.SetActive(true);
                    Loly6Selected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Unselected.SetActive(true);
                    Loly7Selected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Unselected.SetActive(true);
                    Loly8Selected.SetActive(false);

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }


            break;
            case 4:
                    if (Unlocked2 == 1)
                {
                    Loly2Unselected.SetActive(true);
                    Loly2Selected.SetActive(false);
             

                }
                if (Unlocked3 == 1)
                {

                    Loly3Unselected.SetActive(true);
                    Loly3Selected.SetActive(false);
                  

                }
                if (Unlocked4 == 1)
                {
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly4Selected.SetActive(true);
                    Loly4Unselected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Unselected.SetActive(true);
                    Loly5Selected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly6Unselected.SetActive(true);
                    Loly6Selected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Unselected.SetActive(true);
                    Loly7Selected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Unselected.SetActive(true);
                    Loly8Selected.SetActive(false);

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }


            break;
            case 5:

                    if (Unlocked2 == 1)
                {
                    Loly2Unselected.SetActive(true);
                    Loly2Selected.SetActive(false);
             

                }
                if (Unlocked3 == 1)
                {

                    Loly3Unselected.SetActive(true);
                    Loly3Selected.SetActive(false);
                  

                }
                if (Unlocked4 == 1)
                {
                    Loly4Unselected.SetActive(true);
                    Loly4Selected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly5Selected.SetActive(true);
                    Loly5Unselected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly6Unselected.SetActive(true);
                    Loly6Selected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Unselected.SetActive(true);
                    Loly7Selected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Unselected.SetActive(true);
                    Loly8Selected.SetActive(false);

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }
            break;
            case 6:

                    if (Unlocked2 == 1)
                {
                    Loly2Unselected.SetActive(true);
                    Loly2Selected.SetActive(false);
             

                }
                if (Unlocked3 == 1)
                {

                    Loly3Unselected.SetActive(true);
                    Loly3Selected.SetActive(false);
                  

                }
                if (Unlocked4 == 1)
                {
                    Loly4Unselected.SetActive(true);
                    Loly4Selected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Unselected.SetActive(true);
                    Loly5Selected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly6Selected.SetActive(true);
                    Loly6Unselected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Unselected.SetActive(true);
                    Loly7Selected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Unselected.SetActive(true);
                    Loly8Selected.SetActive(false);

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }
            break;
            case 7:

                    if (Unlocked2 == 1)
                {
                    Loly2Unselected.SetActive(true);
                    Loly2Selected.SetActive(false);
             

                }
                if (Unlocked3 == 1)
                {
                    Loly3Unselected.SetActive(true);
                    Loly3Selected.SetActive(false);
                  

                }
                if (Unlocked4 == 1)
                {
                    Loly4Unselected.SetActive(true);
                    Loly4Selected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Unselected.SetActive(true);
                    Loly5Selected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly6Unselected.SetActive(true);
                    Loly6Selected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {

                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly7Selected.SetActive(true);
                    Loly7Unselected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {
                    Loly8Unselected.SetActive(true);
                    Loly8Selected.SetActive(false);

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }
            break;
            case 8:

                    if (Unlocked2 == 1)
                {
                    Loly2Unselected.SetActive(true);
                    Loly2Selected.SetActive(false);
             

                }
                if (Unlocked3 == 1)
                {
                    Loly3Unselected.SetActive(true);
                    Loly3Selected.SetActive(false);
                  

                }
                if (Unlocked4 == 1)
                {
                    Loly4Unselected.SetActive(true);
                    Loly4Selected.SetActive(false);

                }
                if (Unlocked5 == 1)
                {
                    Loly5Unselected.SetActive(true);
                    Loly5Selected.SetActive(false);

                }
                if (Unlocked6 == 1)
                {
                    Loly6Unselected.SetActive(true);
                    Loly6Selected.SetActive(false);
                }
                if (Unlocked7 == 1)
                {
                    Loly7Unselected.SetActive(true);
                    Loly7Selected.SetActive(false);

                }
                if (Unlocked8 == 1)
                {

                    Loly8Unselected.SetActive(false);
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly8Selected.SetActive(true);
                  
                   

                }
                      if (Unlocked9 == 1)
                {
                    Loly9Selected.SetActive(false);
                    Loly9Unselected.SetActive(true);

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }

            break;
            case 9:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
                      if (Unlocked9 == 1)
                {
                    Loly9Unselected.SetActive(false);
                    Loly1Unselected.SetActive(true);
                    Loly1Selected.SetActive(false);
                    Loly9Selected.SetActive(true);
                

                }
                if (Unlocked10 == 1)
                {
                    Loly10Selected.SetActive(false);
                    Loly10Unselected.SetActive(true);

                }
                if (Unlocked11 == 1)
                {
                    Loly11Selected.SetActive(false);
                    Loly11Unselected.SetActive(true);

                }
                if (Unlocked12 == 1)
                {
                    Loly12Selected.SetActive(false);
                    Loly12Unselected.SetActive(true);

                }
                if (Unlocked13 == 1)
                {
                    Loly13Selected.SetActive(false);
                    Loly13Unselected.SetActive(true);

                }
                if (Unlocked14 == 1)
                {
                    Loly14Selected.SetActive(false);
                    Loly14Unselected.SetActive(true);

                }
                if (Unlocked15 == 1)
                {
                    Loly15Selected.SetActive(false);
                    Loly15Unselected.SetActive(true);

                }
                if (Unlocked16 == 1)
                {
                    Loly16Selected.SetActive(false);
                    Loly16Unselected.SetActive(true);

                }
                if (Unlocked17 == 1)
                {
                    Loly17Selected.SetActive(false);
                    Loly17Unselected.SetActive(true);

                }
                if (Unlocked18 == 1)
                {
                    Loly18Selected.SetActive(false);
                    Loly18Unselected.SetActive(true);

                }
                if (Unlocked19 == 1)
                {
                    Loly19Selected.SetActive(false);
                    Loly19Unselected.SetActive(true);

                }
                if (Unlocked20 == 1)
                {
                    Loly20Selected.SetActive(false);
                    Loly20Unselected.SetActive(true);

                }
                if (Unlocked21 == 1)
                {
                    Loly21Selected.SetActive(false);
                    Loly21Unselected.SetActive(true);

                }
                if (Unlocked22 == 1)
                {
                    Loly22Selected.SetActive(false);
                    Loly22Unselected.SetActive(true);

                }
                if (Unlocked23 == 1)
                {
                    Loly23Selected.SetActive(false);
                    Loly23Unselected.SetActive(true);

                }
                if (Unlocked24 == 1)
                {
                    Loly24Selected.SetActive(false);
                    Loly24Unselected.SetActive(true);

                }
            break;
            case 10:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {
             
                Loly10Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly10Selected.SetActive(true);


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 11:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {


                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
               
                Loly11Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly11Selected.SetActive(true);
            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 12:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {

                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly12Selected.SetActive(true);
              

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 13:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {


                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly13Selected.SetActive(true);


            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 14:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {


                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly14Selected.SetActive(true);
                

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 15:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {
                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

             


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly15Selected.SetActive(true);
                
            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 16:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {
                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);
             

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly16Selected.SetActive(true);
                

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 17:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {
                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

               


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly17Selected.SetActive(true);
                

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 18:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {
                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly18Selected.SetActive(true);
                

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 19:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {

                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly19Selected.SetActive(true);
                

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 20:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {

                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly20Selected.SetActive(true);
                

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 21:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {

                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly21Selected.SetActive(true);
                

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 22:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {
                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly22Selected.SetActive(true);
                

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 23:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {

                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);

            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly23Selected.SetActive(true);
                

            }
            if (Unlocked24 == 1)
            {
                Loly24Selected.SetActive(false);
                Loly24Unselected.SetActive(true);

            }
            break;
            case 24:

            if (Unlocked2 == 1)
            {
                Loly2Unselected.SetActive(true);
                Loly2Selected.SetActive(false);


            }
            if (Unlocked3 == 1)
            {
                Loly3Unselected.SetActive(true);
                Loly3Selected.SetActive(false);


            }
            if (Unlocked4 == 1)
            {
                Loly4Unselected.SetActive(true);
                Loly4Selected.SetActive(false);

            }
            if (Unlocked5 == 1)
            {
                Loly5Unselected.SetActive(true);
                Loly5Selected.SetActive(false);

            }
            if (Unlocked6 == 1)
            {
                Loly6Unselected.SetActive(true);
                Loly6Selected.SetActive(false);
            }
            if (Unlocked7 == 1)
            {
                Loly7Unselected.SetActive(true);
                Loly7Selected.SetActive(false);

            }
            if (Unlocked8 == 1)
            {

                Loly8Selected.SetActive(false);
                Loly8Unselected.SetActive(true);



            }
            if (Unlocked9 == 1)
            {

                Loly9Selected.SetActive(false);
                Loly9Unselected.SetActive(true);
            }
            if (Unlocked10 == 1)
            {

                Loly10Selected.SetActive(false);
                Loly10Unselected.SetActive(true);


            }
            if (Unlocked11 == 1)
            {
                Loly11Selected.SetActive(false);
                Loly11Unselected.SetActive(true);

            }
            if (Unlocked12 == 1)
            {
                Loly12Selected.SetActive(false);
                Loly12Unselected.SetActive(true);

            }
            if (Unlocked13 == 1)
            {
                Loly13Selected.SetActive(false);
                Loly13Unselected.SetActive(true);

            }
            if (Unlocked14 == 1)
            {
                Loly14Selected.SetActive(false);
                Loly14Unselected.SetActive(true);

            }
            if (Unlocked15 == 1)
            {
                Loly15Selected.SetActive(false);
                Loly15Unselected.SetActive(true);

            }
            if (Unlocked16 == 1)
            {
                Loly16Selected.SetActive(false);
                Loly16Unselected.SetActive(true);

            }
            if (Unlocked17 == 1)
            {
                Loly17Selected.SetActive(false);
                Loly17Unselected.SetActive(true);

            }
            if (Unlocked18 == 1)
            {
                Loly18Selected.SetActive(false);
                Loly18Unselected.SetActive(true);

            }
            if (Unlocked19 == 1)
            {
                Loly19Selected.SetActive(false);
                Loly19Unselected.SetActive(true);

            }
            if (Unlocked20 == 1)
            {
                Loly20Selected.SetActive(false);
                Loly20Unselected.SetActive(true);

            }
            if (Unlocked21 == 1)
            {
                Loly21Selected.SetActive(false);
                Loly21Unselected.SetActive(true);

            }
            if (Unlocked22 == 1)
            {
                Loly22Selected.SetActive(false);
                Loly22Unselected.SetActive(true);

            }
            if (Unlocked23 == 1)
            {
                Loly23Selected.SetActive(false);
                Loly23Unselected.SetActive(true);

            }
            if (Unlocked24 == 1)
            {
                Loly24Unselected.SetActive(false);
                Loly1Unselected.SetActive(true);
                Loly1Selected.SetActive(false);
                Loly24Selected.SetActive(true);
                

            }
            break;
        }


        /*


              if (about)
              {
                if (time > 0)
                  {
                      time -= Time.deltaTime;
                    //  canvasMenu.rigidbody2D.transform.Translate(new Vector2(40, 0), Space.World);
               //   }
               //   else
                 // {
           
                 //}
           
          
              }*/
        /* if (canvasMenu.transform.position.x == 900)
          {
           
        
              about = false;
          }*/
        SoundIndex = PlayerPrefs.GetInt("Sound", 1);
        MusicIndex = PlayerPrefs.GetInt("Music", 1);
      
        if (Input.GetKeyDown("escape"))
        {
            if (!playerController.Dead)
            {
                if (!about&&!store)
                {

                    if (SoundIndex == 1)
                    {

                        Sound.GetComponent<AudioSource>().Play();

                    }
                    if (!quitvisible)
                    {
                        QuitMenu.SetActive(true);

                        // canvas.SetActive(false);
                        quitvisible = true;
                        if (MusicIndex == 1)
                        {

                            Music.GetComponent<AudioSource>().volume = 0.3f;

                        }

                    }
                    else if (quitvisible)
                    {
                        QuitMenu.SetActive(false);

                        // canvas.SetActive(true);
                        quitvisible = false;
                        if (MusicIndex == 1)
                        {


                            Music.GetComponent<AudioSource>().volume = 0.8f;
                        }

                    }
                }
            }
        }
    }

   
    public void Navigate(string buttonName)
    {
       
       // audio.PlayOneShot(clicSound, 0.1F);
        switch (buttonName)
        {

            case "Play":
                playClicked = true;
                //Invoke("loadgame", 0.3f);
                AutoFade.LoadLevel("sceneGame", 0.2f, 1, Color.black);


                break;
            case "Yes":

            Application.Quit();
            QuitMenu.SetActive(false);
            if (MusicIndex == 1)
            {

                GameObject.Find("Music").GetComponent<AudioSource>().volume = 0.8f;
            }


            break;
            case "No":

            QuitMenu.SetActive(false);
                  
                   // canvas.SetActive(true);
                    quitvisible = false;
                    if (MusicIndex == 1)
                    {

                        GameObject.Find("Music").GetComponent<AudioSource>().volume = 0.8f;
                    }



            break;
            case "Sound":

            if (sound) {
               // SoundButton.GetComponent<SpriteRenderer>().sprite = Resources.Load("soundoff", typeof(Sprite)) as Sprite;
                 SoundButton.GetComponent<Button>().image.sprite=SoundOffSprite;
                GetComponent<AudioSource>().enabled=false;
                sound = false;
                PlayerPrefs.SetInt("Sound", 0);

            }
            else
            {
                SoundButton.GetComponent<Button>().image.sprite = SoundOnSprite;
                GetComponent<AudioSource>().enabled = true;
                sound = true;
                PlayerPrefs.SetInt("Sound", 1);

            }


            break;
            case "Music":

            if (PlayerPrefs.GetInt("Music", 0)==1)
            {
             
                Music.GetComponent<AudioSource>().volume = 0;
               
                MusicButton.GetComponent<Button>().image.sprite = MusicOffSprite;
    
                music = false;
                PlayerPrefs.SetInt("Music", 0);
            }
            else
            {
                Music.GetComponent<AudioSource>().enabled = true;
                Music.GetComponent<AudioSource>().volume = 0.8f;
             
                MusicButton.GetComponent<Button>().image.sprite = MusicOnSprite;
                music = true;

                PlayerPrefs.SetInt("Music", 1);

            }


            break;

            case "FB":
              
                    // WWW www = new WWW("fb://page/DroidBoy-Games");
                    //StartCoroutine(WaitForRequest(www));
                    Application.OpenURL("fb://page/502024229946633");

                
                break;
            case "TW":
            
                
                    Application.OpenURL("twitter://user?user_id=3381721191");
                
                break;

            case "Store":
            store = true;
            canvasMenu.SetActive(false);
            StorePanel.SetActive(true);
            Pack1.SetActive(true);
           // Title.SetActive(false);

            LeftButtonStore.SetActive(false);
            break;

            case "Achiev":
            Social.localUser.Authenticate((bool success) =>
            {
                // handle success or failure
            });
            Social.ShowAchievementsUI();

            break;

            case "Leader":
            Social.localUser.Authenticate((bool success) =>
            {
                // handle success or failure
            });
            Social.ShowLeaderboardUI();

            break;
            case "About":
            about = true;
            //   canvasMenu.rigidbody2D.velocity = new Vector3(9.5f , 0, 0);
            canvasMenu.SetActive(false);
            AboutPanel.SetActive(true);
            Image1.SetActive(true);
            Message1.SetActive(true);
            LeftButton.SetActive(false);


            break;
            case "Left":
            RightButton.SetActive(true);
            LeftButton.SetActive(false);
            MainButton.SetActive(false);
             Image1.SetActive(true);
                Message1.SetActive(true);
             Image2.SetActive(false);
                Message2.SetActive(false);
            break;
            case "Right":
        
                LeftButton.SetActive(true);
                Image1.SetActive(false);
                Message1.SetActive(false);
                Image2.SetActive(true);
             Message2.SetActive(true);
                MainButton.SetActive(true);
                RightButton.SetActive(false);
         
           

            break;

            case "Main":
            AboutPanel.SetActive(false);
            canvasMenu.SetActive(true);
     
            MainButton.SetActive(false);
            
            RightButton.SetActive(true);
            LeftButton.SetActive(false);
                   Image1.SetActive(true);
                Message1.SetActive(true);
             Image2.SetActive(false);
                Message2.SetActive(false);

                about = false;
            break;

            case "Rate":
          //  Application.OpenURL("http://play.google.com/store/apps/details?id=droidboy.lolyjump.loly");
             Application.OpenURL("market://details?id=droidboy.lolyjump.loly");
            break;
            case "LeftStore":
              if (pos2==3){
            RightButtonStore.SetActive(true);
            Pack3.SetActive(false);
            Pack2.SetActive(true);
                   pos2=2;
               }
              else   if (pos2==2){
                      LeftButtonStore.SetActive(false);
            Pack2.SetActive(false);
            Pack1.SetActive(true);
                   pos2=1;
               }
            break;
            case "RightStore":
              if (pos2==1){
            LeftButtonStore.SetActive(true);
            Pack1.SetActive(false);
            Pack2.SetActive(true);
                   pos2=2;
               }
              else if (pos2==2){
            RightButtonStore.SetActive(false);
            Pack2.SetActive(false);
            Pack3.SetActive(true);
                   pos2=3;
               }
            break;
            case "MainStore":
            canvasMenu.SetActive(true);
            StorePanel.SetActive(false);
            Pack1.SetActive(false);
            Title.SetActive(true);
            store = false;
            Pack3.SetActive(false);
            Pack2.SetActive(false);
            LeftButtonStore.SetActive(false);
            RightButtonStore.SetActive(true);
                pos2=1;
            break;

            case "Loly1Select":

            PlayerPrefs.SetInt("SkinSelected",1);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }


            break;
            case "Loly2Unlock":
            if (Total_nb_candy >= 5)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
               
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly2lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy-5);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }

            break;
            case "Loly2Select":

            PlayerPrefs.SetInt("SkinSelected", 2);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly3Unlock":
            if (Total_nb_candy >= 10)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly3lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 10);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly3Select":
            PlayerPrefs.SetInt("SkinSelected", 3);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly4Unlock":
            if (Total_nb_candy >= 15)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly4lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 15);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly4Select":

            PlayerPrefs.SetInt("SkinSelected", 4);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }
            break;
            case "Loly5Unlock":
            if (Total_nb_candy >= 20)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly5lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 20);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }

            break;
            case "Loly5Select":
            PlayerPrefs.SetInt("SkinSelected",5);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly6Unlock":
            if (Total_nb_candy >= 25)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly6lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 25);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly6Select":
            PlayerPrefs.SetInt("SkinSelected",6);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly7Unlock":
            if (Total_nb_candy >= 30)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                  Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly7lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 30);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly7Select":
            PlayerPrefs.SetInt("SkinSelected", 7);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly8Unlock":
            if (Total_nb_candy >= 35)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly8lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 35);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly8Select":
            PlayerPrefs.SetInt("SkinSelected", 8);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;

            case "Loly9Unlock":
            if (Total_nb_candy >= 50)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly9lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 50);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly9Select":
            PlayerPrefs.SetInt("SkinSelected", 9);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly10Unlock":
            if (Total_nb_candy >= 50)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly10lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 50);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly10Select":
            PlayerPrefs.SetInt("SkinSelected", 10);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;

            case "Loly11Unlock":
            if (Total_nb_candy >= 100)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly11lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 100);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly11Select":
            PlayerPrefs.SetInt("SkinSelected", 11);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly12Unlock":
            if (Total_nb_candy >= 100)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly12lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 100);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly12Select":
            PlayerPrefs.SetInt("SkinSelected", 12);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;

            case "Loly13Unlock":
            if (Total_nb_candy >= 150)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly13lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 150);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly13Select":
            PlayerPrefs.SetInt("SkinSelected", 13);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;

            case "Loly14Unlock":
            if (Total_nb_candy >= 150)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly14lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 150);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly14Select":
            PlayerPrefs.SetInt("SkinSelected", 14);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly15Unlock":
            if (Total_nb_candy >= 200)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly15lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 200);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly15Select":
            PlayerPrefs.SetInt("SkinSelected", 15);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;

            case "Loly16Unlock":
            if (Total_nb_candy >= 300)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly16lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 300);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly16Select":
            PlayerPrefs.SetInt("SkinSelected", 16);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly17Unlock":
            if (Total_nb_candy >= 350)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly17lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 350);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly17Select":
            PlayerPrefs.SetInt("SkinSelected", 17);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly18Unlock":
            if (Total_nb_candy >= 400)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly18lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 400);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly18Select":
            PlayerPrefs.SetInt("SkinSelected", 18);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly19Unlock":
            if (Total_nb_candy >= 500)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly19lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 450);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly19Select":
            PlayerPrefs.SetInt("SkinSelected", 19);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly20Unlock":
            if (Total_nb_candy >= 600)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly20lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 500);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly20Select":
            PlayerPrefs.SetInt("SkinSelected", 20);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly21Unlock":
            if (Total_nb_candy >= 700)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly21lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 600);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly21Select":
            PlayerPrefs.SetInt("SkinSelected", 21);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly22Unlock":
            if (Total_nb_candy >= 800)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly22lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 800);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly22Select":
            PlayerPrefs.SetInt("SkinSelected", 22);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly23Unlock":
            if (Total_nb_candy >= 900)
            {
                PlayerPrefs.SetInt("UnlockedSkins", PlayerPrefs.GetInt("UnlockedSkins", 0) + 1);
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly23lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 900);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly23Select":
            PlayerPrefs.SetInt("SkinSelected", 23);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
            case "Loly24Unlock":
            if (Total_nb_candy >= 1000)
            {
                PlayerPrefs.SetInt("UnlockedSkins",   PlayerPrefs.GetInt("UnlockedSkins", 0)+1);

                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                PlayerPrefs.SetInt("Loly24lock", 1);
                PlayerPrefs.SetInt("Total_Candy", Total_nb_candy - 1000);
                if (SoundIndex == 1)
                {

                    GameObject.Find("UnlockSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }
            else
            {
                (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = true;
                Invoke("StopShake", 0.5f);
                if (SoundIndex == 1)
                {
                    GameObject.Find("CantSound").GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
                }
            }


            break;
            case "Loly24Select":
            PlayerPrefs.SetInt("SkinSelected", 24);
            if (SoundIndex == 1)
            {
                BigCanvas.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
            }

            break;
        }

    }

    void OnDestroy()
    {

        PlayerPrefs.SetInt("MainMenuFade", 0);
    }

    void StopShake()
    {
       (MainMenuScore.GetComponent(typeof(Shake2)) as Shake2).enabled = false;


    }
    public void loadgame()
    {
        //    GameObject.Find("GM").GetComponent<FadeScript>().BeginFade(1);


        //PlayerPrefs.SetInt("MainMenuFade", 0);
        //Application.LoadLevel("sceneGame");
     
    }

    void Awake()
    {

        about = false;
        store = false;
      if(  PlayerPrefs.GetInt("MainMenuFade", 0)==1)
          GameObject.Find("GM").GetComponent<FadeScript>().enabled=true;
 

       // PlayerPrefs.SetInt("Total_Candy", 0);
   //  PlayerPrefs.SetInt("highScore", 602);
   // PlayerPrefs.SetInt("Total_Candy", 187);
    /*   PlayerPrefs.SetInt("Loly2lock", 0);
        PlayerPrefs.SetInt("Loly3lock", 0);
        PlayerPrefs.SetInt("Loly4lock", 0);
        PlayerPrefs.SetInt("Loly5lock", 0);
        PlayerPrefs.SetInt("Loly6lock", 0);
        PlayerPrefs.SetInt("Loly7lock", 0);
        PlayerPrefs.SetInt("Loly8lock", 0);
        PlayerPrefs.SetInt("Loly9lock", 0);
        PlayerPrefs.SetInt("Loly10lock", 0);
        PlayerPrefs.SetInt("Loly11lock", 0);
        PlayerPrefs.SetInt("Loly12lock", 0);
        PlayerPrefs.SetInt("Loly13lock", 0);
        PlayerPrefs.SetInt("Loly14lock", 0);
        PlayerPrefs.SetInt("Loly15lock", 0);
        PlayerPrefs.SetInt("Loly16lock", 0);
        PlayerPrefs.SetInt("Loly17lock", 0);
        PlayerPrefs.SetInt("Loly18lock", 0);
        PlayerPrefs.SetInt("Loly19lock", 0);
        PlayerPrefs.SetInt("Loly20lock", 0);
        PlayerPrefs.SetInt("Loly21lock", 0);
        PlayerPrefs.SetInt("Loly22lock", 0);
        PlayerPrefs.SetInt("Loly23lock", 0);
        PlayerPrefs.SetInt("Loly24lock", 0);*/
        Total_nb_candy = PlayerPrefs.GetInt("Total_Candy", 0);
        SkinSelected =  PlayerPrefs.GetInt("SkinSelected",1);
        Unlocked2 = PlayerPrefs.GetInt("Loly2lock", 0);
        Unlocked3 = PlayerPrefs.GetInt("Loly3lock", 0);
        Unlocked4 = PlayerPrefs.GetInt("Loly4lock", 0);
        Unlocked5 = PlayerPrefs.GetInt("Loly5lock", 0);
        Unlocked6 = PlayerPrefs.GetInt("Loly6lock", 0);
        Unlocked7 = PlayerPrefs.GetInt("Loly7lock", 0);
        Unlocked8 = PlayerPrefs.GetInt("Loly8lock", 0);
        Unlocked9 = PlayerPrefs.GetInt("Loly9lock", 0);
        Unlocked10 = PlayerPrefs.GetInt("Loly10lock", 0);
        Unlocked11 = PlayerPrefs.GetInt("Loly11lock", 0);
        Unlocked12 = PlayerPrefs.GetInt("Loly12lock", 0);
        Unlocked13 = PlayerPrefs.GetInt("Loly13lock", 0);
        Unlocked14 = PlayerPrefs.GetInt("Loly14lock", 0);
        Unlocked15 = PlayerPrefs.GetInt("Loly15lock", 0);
        Unlocked16 = PlayerPrefs.GetInt("Loly16lock", 0);
        Unlocked17 = PlayerPrefs.GetInt("Loly17lock", 0);
        Unlocked18 = PlayerPrefs.GetInt("Loly18lock", 0);
        Unlocked19 = PlayerPrefs.GetInt("Loly19lock", 0);
        Unlocked20 = PlayerPrefs.GetInt("Loly20lock", 0);
        Unlocked21 = PlayerPrefs.GetInt("Loly21lock", 0);
        Unlocked22 = PlayerPrefs.GetInt("Loly22lock", 0);
        Unlocked23 = PlayerPrefs.GetInt("Loly23lock", 0);
        Unlocked24 = PlayerPrefs.GetInt("Loly24lock", 0);



        Music.GetComponent<AudioSource>().enabled = false;
        SoundIndex = PlayerPrefs.GetInt("Sound", 1);
        MusicIndex = PlayerPrefs.GetInt("Music", 1);

        if (SoundIndex == 0)
        {
            SoundButton.GetComponent<Button>().image.sprite = SoundOffSprite;
            GetComponent<AudioSource>().enabled = false;
     
            sound = false;

        }
        else if (SoundIndex == 1)
        {

            SoundButton.GetComponent<Button>().image.sprite = SoundOnSprite;
            GetComponent<AudioSource>().enabled = true;
            sound = true;

        }
        if (MusicIndex == 0)
        {
            Music.GetComponent<AudioSource>().enabled = true;
            Music.GetComponent<AudioSource>().volume = 0;
            MusicButton.GetComponent<Button>().image.sprite = MusicOffSprite;

            music = false;

        }
        else if (MusicIndex == 1)
        {
            Music.GetComponent<AudioSource>().enabled = true;
            Music.GetComponent<AudioSource>().Stop();

           
        
            Invoke("volume", 0.3f);
           

            MusicButton.GetComponent<Button>().image.sprite = MusicOnSprite;
            music = true;

        }

    }
    void volume()
    {
        Music.GetComponent<AudioSource>().volume = 0.8f;
        Music.GetComponent<AudioSource>().Play();

    }
   

   

 
       

    
}
