using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 using GooglePlayGames;
    using UnityEngine.SocialPlatforms;
using UnityEngine.EventSystems;
public class playerController : MonoBehaviour
{
    static public bool pauseCheck = true;
    public static bool Dead;
    public static bool GodMode;
    bool collided;
    float Timed = 2f;
    bool off = true;
    public GameObject heart1, heart2, heart3;
    public Texture[] HSprites;
    public GameObject tuto;
    public GameObject particle;
    public float FirstYPosition = 0f;
    public float SecondYPosition = 0f;
    // Drag your second sprite here
    public static bool isGrounded = false;
    private SpriteRenderer spriteRenderer;
    public static float position = 2;
    float velocity = 0.07f;
    public Sprite[] sprites;
    public static bool jumpedtwice;
    public static bool isFlying = false;

    public static float result;
    public Rigidbody2D rb;
    bool nextstage = false;
    float time2 = 0.5f;
    float time22 = 1f;
    public GameObject cam;
    bool open = false;
    public GameObject canvas1;
    public GameObject canvas2;
    int NBH;
    Animator anim;
    public GameObject monsters;
    public LayerMask pause;
    int selectedskin;
    Touch touch;
    // Use this for initialization
    public static bool over;
    public void activatePlayer()
    {
        gameObject.GetComponent<Animator>().enabled = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;

    }
  
    void Awake()
    {
        NBH = 3;
        //InvokeRepeating("Blink", 0, 0.4f);

        Timed = 2f;

        jumpedtwice = false;
        Dead = false;
        position = 2;
        monsters.SetActive(true);
        anim = GetComponent<Animator>();
        over = false;
        isFlying = false;
        rb = GetComponent<Rigidbody2D>();

     //   gameObject.GetComponent<Animator>().enabled = false;
       // gameObject.GetComponent<SpriteRenderer>().enabled = false;
        
        selectedskin = PlayerPrefs.GetInt("SkinSelected", 1);
        switch (selectedskin)
        {


            case 1:
                anim.speed=0;
                
                        anim.SetBool("jumped", !open);
                        anim.Play("player1");
                break;
            case 2:
                anim.SetInteger("skin", 2);
               // anim.SetBool("jumped", !open);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                
                        anim.SetBool("jumped", !open);
                        anim.Play("player2");
                break;
            case 3:
                anim.SetInteger("skin", 3);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);
                
                        anim.SetBool("jumped", !open);
                        anim.Play("player3");
                break;
            case 4:
                anim.SetInteger("skin", 4);
                anim.speed = 1;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);
                
                        anim.SetBool("jumped", !open);
                        anim.Play("player4");
                break;
            case 5:
                anim.SetInteger("skin", 5);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);
                
            
                     

                        anim.SetBool("jumped", !open);
                        anim.Play("player5");
                break;
            case 6:
                anim.SetInteger("skin", 6);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);
                
                        anim.SetBool("jumped", !open);
                        anim.Play("player6");
                break;
            case 7:
                anim.SetInteger("skin", 7);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);
                
                        anim.SetBool("jumped", !open);
                        anim.Play("player7");
                break;
            case 8:
                anim.SetInteger("skin", 8);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);
                
                        anim.SetBool("jumped", !open);
                        anim.Play("player8");
                break;

            case 9:
                anim.SetInteger("skin", 9);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player9");
                break;
            case 10:
                anim.SetInteger("skin", 10);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player10");
                break;
            case 11:
                anim.SetInteger("skin", 11);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player11");
                break;
            case 12:
                anim.SetInteger("skin", 12);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player12");
                break;
            case 13:
                anim.SetInteger("skin", 13);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player13");
                break;
            case 14:
                anim.SetInteger("skin", 14);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player14");
                break;
            case 15:
                anim.SetInteger("skin", 15);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player15");
                break;
            case 16:
                anim.SetInteger("skin", 16);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player16");
                break;
            case 17:
                anim.SetInteger("skin", 17);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player17");
                break;
            case 18:
                anim.SetInteger("skin", 18);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player18");
                break;
            case 19:
                anim.SetInteger("skin", 19);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player19");
                break;
            case 20:
                anim.SetInteger("skin", 20);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player20");
                break;
            case 21:
                anim.SetInteger("skin", 21);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player21");
                break;
            case 22:
                anim.SetInteger("skin", 22);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player22");
                break;
            case 23:
                anim.SetInteger("skin", 23);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player24");
                break;
            case 24:
                anim.SetInteger("skin", 24);
                anim.speed = 0;
                gameObject.transform.localScale = new Vector3(-0.8140759f, 0.9442588f, 0.8140759f);

                anim.SetBool("jumped", !open);
                anim.Play("player24");
                break;
        }
    }
     public void Blink2()
    {
        if(Timed > 0)
        {
            if (PauseMenuNavigation.paused)
            {
                Time.timeScale = 0;

                GameObject.Find("Hitted").GetComponent<AudioSource>().enabled = false;
            }
            else
            {
                Time.timeScale = 0.8f;

                GameObject.Find("Hitted").GetComponent<AudioSource>().enabled = true;
                GameObject.Find("Music").GetComponent<AudioSource>().pitch = 0.95f;

            }

            Timed = Timed - Time.deltaTime;
           
            gameObject.GetComponent<SpriteRenderer>().enabled = (Time.time % 0.25 > 0.125f);
           // particle.SetActive(Time.time % 0.25 > 0.125f);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            particle.SetActive(true);
            GodMode = false;
            GameObject.Find("Hittedslow").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("Hittedslow2").GetComponent<AudioSource>().enabled = true;
            Time.timeScale = 1;
        }

    }
    public void Blink()
    {
        StartCoroutine(Wait());

    }
    public IEnumerator Wait()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(0.2f);
     StopCoroutine(Wait());
        GodMode = false;
        GameObject.Find("Hittedslow2").GetComponent<AudioSource>().enabled = true;
        GameObject.Find("Hittedslow").GetComponent<AudioSource>().enabled = false;
    }
    public void stopinvoke()
    {
       
        //CancelInvoke("Blink");
       
        
    }
    void Start()
    {
       // particle.SetActive(false);


    }

    // Update is called once per frame


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Ground")
        {
            other.gameObject.GetComponent<Collider2D>().isTrigger = true;
           
        }
        if (other.gameObject.tag == "Heart")
        {
            if (NBH < 3)
            {

               
                     if (NBH == 2)
                {
                    heart3.GetComponent<RawImage>().texture = HSprites[1];
                    NBH++;
                   
                }
                else
                     if (NBH == 1)
                {
                    heart2.GetComponent<RawImage>().texture = HSprites[1];
                    NBH++;

                }

            }

        }

            if (other.gameObject.tag == "monster")
        {

            if (NBH > 0 && !GodMode)
            {

                if (NBH == 3)
                {
                    heart3.GetComponent<RawImage>().texture = HSprites[0];
                    NBH--;
                    GodMode = true;
                }
                else
                     if (NBH == 2)
                {
                    heart2.GetComponent<RawImage>().texture = HSprites[0];
                    NBH--;
                    GodMode = true;
                }
                else
                     if (NBH == 1)
                {
                    heart1.GetComponent<RawImage>().texture = HSprites[0];
                    NBH--;
                   
                }

            }
             if (NBH == 0 && !GodMode)
            {
               
                if ( PlayerPrefs.GetInt("NumberOfDeath", 0) < 12)
            {
                PlayerPrefs.SetInt("NumberOfDeath", PlayerPrefs.GetInt("NumberOfDeath", 0) + 1);
            }

            Dead = true;

            (cam.GetComponent(typeof(shake)) as shake).enabled = true;
            (other.GetComponent(typeof(MonsterController)) as MonsterController).enabled = false;
               GameObject.Find("spinnerHalf_spin (1)").GetComponent<SpinnerController>().enabled = false;
                GameObject.Find("spinnerHalf_spin (2)").GetComponent<SpinnerController>().enabled = false;
                GameObject.Find("spinnerHalf_spin").GetComponent<SpinnerController>().enabled = false;
                (gameObject.GetComponent(typeof(playerController)) as playerController).enabled = false;
             
                // monsters.SetActive(false);

                // canvas2.SetActive(true);




                if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                other.GetComponent<Collider2D>().enabled = false;
                GameObject.Find("Hit").GetComponent<AudioSource>().Play();
           
               
                //GameObject.Find("Music").GetComponent<AudioSource>().volume = 0;
            }
            anim.speed = 0;
            other.GetComponent<Animator>().speed = 0;
            GetComponent<Rigidbody2D>().transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
            Invoke("StopShake", 0.3f);
           
            Invoke("GameOver", 1.2f);
                // Application.LoadLevel("sceneGame");
            }
        }
        if (other.gameObject.tag == "monster2")
        {
            if (NBH > 0 && !GodMode)
            {

                if (NBH == 3)
                {
                    heart3.GetComponent<RawImage>().texture = HSprites[0];
                    NBH--;
                    GodMode = true;
                }
                else
                     if (NBH == 2)
                {
                    heart2.GetComponent<RawImage>().texture = HSprites[0];
                    NBH--;
                    GodMode = true;
                }
                else
                     if (NBH == 1)
                {
                    heart1.GetComponent<RawImage>().texture = HSprites[0];
                    NBH--;

                }

            }
            if (NBH == 0 && !GodMode)
            {
                if (PlayerPrefs.GetInt("NumberOfDeath", 0) < 12)
                {
                    PlayerPrefs.SetInt("NumberOfDeath", PlayerPrefs.GetInt("NumberOfDeath", 0) + 1);
                }

                Dead = true;

                (cam.GetComponent(typeof(shake)) as shake).enabled = true;
                GameObject.Find("fly").GetComponent<MonsterController>().enabled = false;
                // GameObject.Find("bat (1)").GetComponent<MonsterController>().enabled = false;
                GameObject.Find("spinnerHalf_spin (1)").GetComponent<SpinnerController>().enabled = false;
                GameObject.Find("spinnerHalf_spin (2)").GetComponent<SpinnerController>().enabled = false;
                GameObject.Find("spinnerHalf_spin").GetComponent<SpinnerController>().enabled = false;
               
                
                // (other.GetComponent(typeof(SpinnerController)) as SpinnerController).enabled = false;
                (gameObject.GetComponent(typeof(playerController)) as playerController).enabled = false;
                // monsters.SetActive(false);
               
                // canvas2.SetActive(true);




                if (PlayerPrefs.GetInt("Sound", 1) == 1)
                {
                    other.GetComponent<Collider2D>().enabled = false;
                    GameObject.Find("Hit").GetComponent<AudioSource>().Play();


                    //GameObject.Find("Music").GetComponent<AudioSource>().volume = 0;
                }
                anim.speed = 0;
                other.GetComponent<Animator>().speed = 0;
                GetComponent<Rigidbody2D>().transform.Translate(Vector3.forward * Time.deltaTime, Space.World);

                Invoke("StopShake", 0.3f);
                Invoke("GameOver", 1.2f);
                // Application.LoadLevel("sceneGame");
            }
        }


    }
    void GameOver()
    {
        over = true;

        monsters.SetActive(false);
        canvas1.SetActive(false);
        canvas2.SetActive(true);
       gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("Score", 0) == 0)
        {
           

            Social.ReportScore(PlayerPrefs.GetInt("Score", 0), "CgkIy9_U8-4JEAIQBg", (bool success) =>
            {
                // handle success or failure
            });
         
        }
        if (PlayerPrefs.GetInt("Score", 0) > 0 && (PlayerPrefs.GetInt("Score", 0) > PlayerPrefs.GetInt("highScore", 0)))
        {
            if (PlayerPrefs.GetInt("Music", 1) == 1)
            {
                GameObject.Find("Music").GetComponent<AudioSource>().volume = 0;
                GameObject.Find("HighScore").GetComponent<AudioSource>().Play();

            }
            else
            {
                GameObject.Find("HighScore").GetComponent<AudioSource>().Play();
            }
          
            Social.ReportScore(PlayerPrefs.GetInt("Score", 0), "CgkIy9_U8-4JEAIQBg", (bool success) =>
            {
                // handle success or failure
            });
            PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("Score", 0));
            GameObject.Find("BestImage").GetComponent<Image>().sprite = sprites[1];
        }
        if (PlayerPrefs.GetInt("Music", 1) == 1)
        {
            GameObject.Find("Music").GetComponent<AudioSource>().volume = 0.3f;
       
            
        }
/*
        if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            GameObject.Find("Loose").GetComponent<AudioSource>().Play();

        }
  */
 }

    void StopShake()
    {
        (cam.GetComponent(typeof(shake)) as shake).enabled = false;


    }
    void OnTriggerExit2D(Collider2D other)
    {

        if (!isFlying)
        {
            if (other.gameObject.tag == "Ground")
            {
                other.gameObject.GetComponent<Collider2D>().isTrigger = true;
            }
        }
        if (other.gameObject.tag == "Ground")
        {

            if (PlayerPrefs.GetInt("Score", 0) > 0 && (PlayerPrefs.GetInt("Score", 0) == PlayerPrefs.GetInt("highScore", 0)))
            {
                if (PlayerPrefs.GetInt("Sound", 1) == 1 && !playerController.Dead)
                {

                    GameObject.Find("HighScoreingame").GetComponent<AudioSource>().Play();


                    //GameObject.Find("Music").GetComponent<AudioSource>().volume = 0;
                }
            }
            other.gameObject.GetComponent<Collider2D>().isTrigger = false;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            jumpedtwice = true;

            if (collision.gameObject.GetComponent<Collider2D>().isTrigger == false)
            {

                isGrounded = true;
            }
            if (nextstage)
            {
                SecondYPosition = this.transform.position.y;
                result = SecondYPosition - FirstYPosition;
                Debug.Log("result " + result);
                if (!Dead)
                {



                    if ((result > 1.99f) && (result < 2.1f))
                    {
                        ScoreScript.AddPoint();
                        //audio.PlayOneShot(jumpSound2, 0.005F);
                        FirstYPosition = this.transform.position.y;
                    }
                }

            }
            else
            {
                FirstYPosition = this.transform.position.y;
            }

            isGrounded = true;
        }

    }



    void jump()
    {
        jumpedtwice = false;


        if (isGrounded == true)
        {
            //   rigidbody2D.transform.Translate(new Vector2(0f, 100f) * Time.deltaTime, Space.World);
            if(collided)
            {
                rb.velocity = new Vector3(-0.3f, 9, 0);
            }
            else 
            {
                rb.velocity = new Vector3(0.3f, 9, 0);
            }
                //  rigidbody2D.AddForce(new Vector2(0f, 550f));

            if (PlayerPrefs.GetInt("Sound", 1) == 1)
            {
                GameObject.Find("Jump").GetComponent<AudioSource>().Play();

            }
            nextstage = false;
            isGrounded = false;
            isFlying = true;
        }

        else if (!isGrounded && isFlying == true)
        {
           
            if (collided)
            {
                rb.velocity = new Vector3(-0.3f, 10f, 0);
            }
            else
            {
                rb.velocity = new Vector3(0.3f, 10f, 0);
            }
         




            isFlying = false;
            nextstage = true;


        }
    }
  
    void OnTouchBegan(Vector2 screenPos)
    {
        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            hit.collider.gameObject.SendMessage("OnClick", SendMessageOptions.DontRequireReceiver);
        }
    }
   
   
    void Update()
    {
       


        if (!Dead)
        {

            if (GodMode)
            {

                GameObject.Find("Hittedslow").GetComponent<AudioSource>().enabled = true;
                GameObject.Find("Hittedslow2").GetComponent<AudioSource>().enabled = false;
                particle.SetActive(false);
                Blink2();
             /*  
                if (selectedskin == 1)
                {
                    transform.localScale = new Vector3(0.6331698f, 0.7664059f, 0.6331698f);
                }
                else
                {
                    transform.localScale = new Vector3(-0.6331698f, 0.7664059f, 0.6331698f);
                }
               */
              
               
             

            }
            else
            {

                Timed = 2f;
                GameObject.Find("Hitted").GetComponent<AudioSource>().enabled = false;
                GameObject.Find("Music").GetComponent<AudioSource>().pitch = 1;
               
                particle.SetActive(true);
              /*  if (selectedskin == 1)
                {
                    transform.localScale = new Vector3(0.8331698f, 0.9664059f, 0.8331698f);
                }
                else
                {
                    transform.localScale = new Vector3(-0.8331698f, 0.9664059f, 0.8331698f);
                }
                
                */
            }

            if (time22 > 0)
                time22 -= Time.deltaTime;

            else {
                if (PlayerPrefs.GetInt("tuto", 0) == 0)
                {

                    Time.timeScale = 0;
                    tuto.SetActive(true);
                }


            }

            if (PlayerPrefs.GetInt("tuto", 0) == 1)
            {

                
                tuto.SetActive(false);
            }
            if (time2 > 0)
                time2 -= Time.deltaTime;
            else
            {
               

                // particle.SetActive(false);
                /*    if (Input.GetTouch(0).phase == TouchPhase.Began)
                    {
                        {
                            RaycastHit2D hit;
                            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                            hit = Physics2D.Raycast(ray.origin, ray.direction, 10, pause);
                            if (hit.transform != null)
                            {
                                Debug.DrawLine(transform.position, Vector3.zero, Color.white, 5f, false);
                                Debug.Log("HIT");

                            }
                        }*/
                /*
                                foreach (Touch touch in Input.touches)
                                {
                                    int pointerID = touch.fingerId;
                                    if (EventSystem.current.IsPointerOverGameObject (pointerID))
                                    {
                                        // at least on touch is over a canvas UI


                                        return;
                                    }
                                    else
                                    {


                                    }

                                    if (touch.phase == TouchPhase.Ended)
                                    {
                                        // here we don't know if the touch was over an canvas UI

                                        return;
                                    }

                                }
                               */

                if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) )
                        {
              
                            int pointerID =touch.fingerId;
                            if (EventSystem.current.IsPointerOverGameObject(pointerID))
                            {

                            }
                            else { jump(); }
                         

                        }
             
                /*
              
                 if ( Application.platform == RuntimePlatform.IPhonePlayer ||
             Application.platform == RuntimePlatform.Android )
         {
             if ( Input.touchCount <= 0 )
                 return;
             
             // detect single touch only
             Touch touch  = Input.touches[0];
             
             if ( touch.phase == TouchPhase.Began )
             {
                             Debug.Log( 123 );
                 OnTouchBegan( touch.position );
                
             }
         }
         else
         {
             if ( Input.GetMouseButtonDown( 0 ) )
             {
                             
                             Debug.Log(Screen.width-2);

                             if ((Screen.width-Input.mousePosition.x>100) &&(Screen.height-Input.mousePosition.y)>100){
                               
                             }
                 OnTouchBegan( Input.mousePosition );
               
             }
         }
     
     
 */
 
                  




                }
            }
     



   
            switch (selectedskin)
            {


                case 1:
                    if (isGrounded)
                    {

                        
                        anim.SetBool("jumped", open);
                        anim.speed = 1;
                        anim.Play("player1");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 2:
                    anim.SetInteger("skin", 2);
                    if (isGrounded)
                    {

                        anim.speed = 1;
                        anim.SetBool("jumped", open);
                        anim.Play("player2");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }




                    break;
                case 3:
                    anim.SetInteger("skin", 3);
                    if (isGrounded)
                    {

                        anim.speed = 1;
                        anim.SetBool("jumped", open);
                        anim.Play("player3");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 4:
                    anim.SetInteger("skin", 4);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player4");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 5:
                    anim.SetInteger("skin", 5);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player5");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 6:
                    anim.SetInteger("skin", 6);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player6");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 7:
                    anim.SetInteger("skin", 7);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player7");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 8:
                    anim.SetInteger("skin", 8);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player8");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 9:
                    anim.SetInteger("skin", 9);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player9");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 10:
                    anim.SetInteger("skin", 10);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player10");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 11:
                    anim.SetInteger("skin", 11);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player11");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 12:
                    anim.SetInteger("skin", 12);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player12");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 13:
                    anim.SetInteger("skin", 13);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player13");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 14:
                    anim.SetInteger("skin", 14);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player14");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 15:
                    anim.SetInteger("skin", 15);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player15");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 16:
                    anim.SetInteger("skin", 16);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player16");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 17:
                    anim.SetInteger("skin", 17);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player17");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 18:
                    anim.SetInteger("skin", 18);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player18");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 19:
                    anim.SetInteger("skin", 19);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player19");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 20:
                    anim.SetInteger("skin", 20);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player20");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 21:
                    anim.SetInteger("skin", 21);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player21");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 22:
                    anim.SetInteger("skin", 22);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player22");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 23:
                    anim.SetInteger("skin", 23);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player23");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;
                case 24:
                    anim.SetInteger("skin", 24);
                    if (isGrounded)
                    {
                        anim.speed = 1;

                        anim.SetBool("jumped", open);
                        anim.Play("player24");
                    }
                    else
                    {


                        anim.SetBool("jumped", !open);
                    }

                    break;

            }
          


            if (time2 > 0)
                time2 -= Time.deltaTime;
            else
            {


                this.GetComponent<Rigidbody2D>().gravityScale = 3.6f;
                if (transform.position.x >= 2.1f)
                {
                    transform.localRotation = Quaternion.Euler(0, 0, 0);
                    collided = true;
                }
                if (transform.position.x < -2.1f)
                {
                    transform.localRotation = Quaternion.Euler(0, 180, 0);
                    collided = false;
                }


                if (collided == true)
                {


               

                position -= velocity;

                //Debug.Log(position+"");
                // transform.position = new Vector3(position, transform.position.y, transform.position.z);
                // rb.velocity = new Vector3(-0.1f, 0, 0);
                GetComponent<Rigidbody2D>().transform.Translate(new Vector2(-2f, 0) * Time.deltaTime, Space.World);


            }


                if (collided == false)
                {

                  


                position += velocity;
                    // transform.position = new Vector3(position, transform.position.y, transform.position.z);
                    // rb.velocity = new Vector3(0.1f, 0, 0);
                    //	Debug.Log(position+"");
                 
                    //	transform.position = new Vector2(position,0f);
                    GetComponent<Rigidbody2D>().transform.Translate(new Vector2(2f, 0) * Time.deltaTime, Space.World);


                }



            }


        }



   
}




