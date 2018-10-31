using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;


public class PauseMenuNavigation : MonoBehaviour {
    public static bool mainmenu;
    public bool music = true;
    public bool sound = true;
    public GameObject SoundButton;
    public GameObject MusicButton;
    public GameObject Music;
    public GameObject Sound;
    public Sprite SoundOffSprite;
    public Sprite SoundOnSprite;
    public Sprite MusicOffSprite;
    public Sprite MusicOnSprite;
    public GameObject AboutPanel;
    public GameObject LeftButton;
    public GameObject RightButton;
    public GameObject MainButton;
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Message1;
    public GameObject Message2;
    public GameObject AboutPanel1;
    public GameObject LeftButton1;
    public GameObject RightButton1;
    public GameObject MainButton1;
    public GameObject Image11;
    public GameObject Image21;
    public GameObject Message11;
    public GameObject Message21;
    bool about;
   public static int SoundIndex = 1;
   public static int MusicIndex = 1;
  public  GameObject menu;
    public static bool paused =false;
    EventSystem eventSystem;
      
    public GameObject canvas;

 private Vector2 touchCoordinates;
 int score;

 void Update()
 {


     score=PlayerPrefs.GetInt("Score", 0);

     if (score == 50)
     {
         Social.ReportProgress("CgkIy9_U8-4JEAIQAQ", 100.0f, (bool success) =>
         {
             // handle success or failure
         });
     }
     if (score == 100)
     {
         Social.ReportProgress("CgkIy9_U8-4JEAIQAg", 100.0f, (bool success) =>
         {
             // handle success or failure
         });
     }
        if (score == 150)
     {
         Social.ReportProgress("CgkIy9_U8-4JEAIQBw", 100.0f, (bool success) =>
         {
             // handle success or failure
         });
     }
    
     if (score == 250)
     {
         Social.ReportProgress("CgkIy9_U8-4JEAIQAw", 100.0f, (bool success) =>
         {
             // handle success or failure
         });
     }
     if (score == 750)
     {
         Social.ReportProgress("CgkIy9_U8-4JEAIQBA", 100.0f, (bool success) =>
         {
             // handle success or failure
         });
     }
     if (score == 1000)
     {
         Social.ReportProgress("CgkIy9_U8-4JEAIQBQ", 100.0f, (bool success) =>
         {
             // handle success or failure
         });
     }
     SoundIndex = PlayerPrefs.GetInt("Sound", 1);
     MusicIndex = PlayerPrefs.GetInt("Music", 1);
   


     if (!playerController.Dead)
     {
         if (paused)
         {
            
             if (MusicIndex == 1)
             {
                 Music.GetComponent<AudioSource>().volume = 0.3f;
             }
         }
         if (!paused)
         {
           
             if (MusicIndex == 1)
             {
                 Music.GetComponent<AudioSource>().volume = 0.8f;
             }
         }
         if (Input.GetKeyDown("escape"))
         {

             if (!playerController.Dead)
             {

                 if (SoundIndex == 1)
                 {

                     Sound.GetComponent<AudioSource>().Play();

                 }
                    if (!paused && !about )
                    {
                        menu.SetActive(true);
                        Time.timeScale = 0;
                        canvas.SetActive(false);
                        paused = true;

                    }
                   
                 else if (paused&&!about)
                 {
                     menu.SetActive(false);
                     Time.timeScale = 1;
                     canvas.SetActive(true);
                     paused = false;


                 }
             }
         }
     }
 }

    public void PauseMenu(string buttonName)
    {

        switch (buttonName)
        {

            case "About":
                about = true;
                //   canvasMenu.rigidbody2D.velocity = new Vector3(9.5f , 0, 0);
                menu.SetActive(false);
                AboutPanel.SetActive(true);
                Image1.SetActive(true);
                Message1.SetActive(true);
                LeftButton.SetActive(false);

           

                break;
            case "Rate":
               
                 Application.OpenURL("market://details?id=droidboy.lolyjump.loly");
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
            case "Left1":
                RightButton1.SetActive(true);
                LeftButton1.SetActive(false);
                MainButton1.SetActive(false);
                Image11.SetActive(true);
                Message11.SetActive(true);
                Image21.SetActive(false);
                Message21.SetActive(false);
                break;
            case "Right1":

                LeftButton1.SetActive(true);
                Image11.SetActive(false);
                Message11.SetActive(false);
                Image21.SetActive(true);
                Message21.SetActive(true);
                MainButton1.SetActive(true);
                RightButton1.SetActive(false);



                break;
            case "MainAbout1":
                AboutPanel1.SetActive(false);

                MainButton1.SetActive(false);
                Time.timeScale = 1;
                RightButton1.SetActive(true);
                LeftButton1.SetActive(false);
                Image11.SetActive(true);
                Message11.SetActive(true);
                Image21.SetActive(false);
                Message21.SetActive(false);

                PlayerPrefs.SetInt("tuto", 1);
                about = false;
                break;
            case "MainAbout":
                AboutPanel.SetActive(false);
                menu.SetActive(true);

                MainButton.SetActive(false);

                RightButton.SetActive(true);
                LeftButton.SetActive(false);
                Image1.SetActive(true);
                Message1.SetActive(true);
                Image2.SetActive(false);
                Message2.SetActive(false);

                about = false;
                break;
            case "Pause":
                paused = true;
              menu.SetActive(true);
              Time.timeScale = 0;
              playerController.pauseCheck = false;
              canvas.SetActive(false);
              playerController.over = true;
             
                break;

            case "Resume":
                playerController.pauseCheck = true;
                paused = false;
                canvas.SetActive(true);
                menu.SetActive(false);
                Time.timeScale =1;
               playerController.over = false;
               
                break;
            case "Reload":
                Music.GetComponent<AudioSource>().Stop();
                Music.GetComponent<AudioSource>().volume = 0;
                playerController.pauseCheck = true;
               // Invoke("ReLoadGame", 0.3f);
                Application.LoadLevel("sceneGame");
                paused = false;
                playerController.over = false;
                Time.timeScale = 1;
                break;


            case "MainMenu":
                Music.GetComponent<AudioSource>().Stop();
                Music.GetComponent<AudioSource>().volume = 0;
                //Invoke("LoadMain", 0.3f);
                Time.timeScale = 1;
                playerController.pauseCheck = true;
                PlayerPrefs.SetInt("NumberOfDeath", 0);
                Application.LoadLevel("MainMenu");
                paused = false;
                mainmenu = true;
                playerController.over = false;
                playerController.Dead = false;
                PlayerPrefs.SetInt("MainMenuFade", 1);
                  MainMenuNavigation.about = false;
        MainMenuNavigation.store = false;
                break;
            case "Sound":

                if (sound)
                {
                    // SoundButton.GetComponent<SpriteRenderer>().sprite = Resources.Load("soundoff", typeof(Sprite)) as Sprite;
                    SoundButton.GetComponent<Button>().image.sprite = SoundOffSprite;
                    GetComponent<AudioSource>().enabled = false;
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

                if (music)
                {
                    GameObject.Find("Music").GetComponent<AudioSource>().volume = 0;

                    MusicButton.GetComponent<Button>().image.sprite = MusicOffSprite;

                    music = false;
                    PlayerPrefs.SetInt("Music", 0);
                }
                else
                {
                    GameObject.Find("Music").GetComponent<AudioSource>().volume = 0.8f;

                    MusicButton.GetComponent<Button>().image.sprite = MusicOnSprite;
                    music = true;

                    PlayerPrefs.SetInt("Music", 1);

                }


                break;
            case "Share":

                AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");

//instantiate the object Intent
AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");

//call setAction setting ACTION_SEND as parameter
intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));

//instantiate the class Uri
AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");

//instantiate the object Uri with the parse of the url's file
                Texture2D screenTexture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, true);
        // put buffer into texture
        screenTexture.ReadPixels(new Rect(0f, 0f, Screen.width, Screen.height), 0, 0);
        // apply
        screenTexture.Apply();
                 byte[] dataToSave = screenTexture.EncodeToPNG();
                string destination = Path.Combine(Application.persistentDataPath,System.DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".png");
               File.WriteAllBytes(destination, dataToSave);
AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://" + destination);
//AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://expl.jpg");

//call putExtra with the uri object of the file
intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);

//set the type of file
intentObject.Call<AndroidJavaObject>("setType", "image/jpeg");

//instantiate the class UnityPlayer
AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

//instantiate the object currentActivity
AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

//call the activity with our Intent
currentActivity.Call("startActivity", intentObject);
Time.timeScale = 1;
                break;

          
        }
    }

    void Awake()
    {
      // eventSystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
      //  eventSystem.sendNavigationEvents = false;
        SoundIndex = PlayerPrefs.GetInt("Sound", 1);
        MusicIndex = PlayerPrefs.GetInt("Music", 1);
        mainmenu = false;
      

        about = false;
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

            Music.GetComponent<AudioSource>().volume = 0;

            MusicButton.GetComponent<Button>().image.sprite = MusicOffSprite;

            music = false;

        }
        else if (MusicIndex == 1)
        {
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
