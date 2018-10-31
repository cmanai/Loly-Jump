using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CandyController : MonoBehaviour
{
    bool Dead;
    bool collided;
    bool collidedleft, collidedright;
    // Drag your second sprite here
    float time = 0.5f;
    public bool isGrounded = true;
    public GameObject bubble;
    bool jumped = true;
    public Sprite plusone;
    public Sprite candy;
    private SpriteRenderer spriteRenderer;
    List<float> randomElementPositionX = new List<float>();
    List<float> randomElementPositionY = new List<float>();
    public GameObject leftwall, rightwall;
    float oldpos;

    // Use this for initialization
    void Start()
    {

        randomElementPositionX.Add(-1.5f);
        randomElementPositionX.Add(0f);
        randomElementPositionX.Add(1.5f);


        

        this.transform.position = new Vector3(randomElementPositionX[Random.Range(0, 3)], transform.position.y + 28, transform.position.z);
        oldpos = this.transform.position.y + 28;
        leftwall.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.1f, leftwall.transform.position.z);
        rightwall.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.8f, rightwall.transform.position.z);
    }

    // Update is called once per frame


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "LeftWall")
        {
            collidedleft = true;
            collidedright = false;
        }
        if (other.gameObject.tag == "RightWall")
        {
            collidedright = true;
            collidedleft = false;
        }
        if (other.gameObject.tag == "Finish")
        {

            if (!playerController.Dead)
            {
                if (PlayerPrefs.GetInt("Sound", 1) == 1)
                {
                    GameObject.Find("Candy").GetComponent<AudioSource>().Play();

                }
           
                CandyScript.AddPoint();
              
              gameObject.GetComponent<SpriteRenderer>().sprite = plusone;
              gameObject.GetComponent<Collider2D>().enabled = false;
                gameObject.transform.localScale = new Vector3(0.535423f, 0.535423f, 0.535423f);
                Invoke("MoveObject", 0.3f);
                
            }
        }

    }

    public void MoveObject()
    {
       
        this.transform.position = new Vector3(randomElementPositionX[Random.Range(0, 3)],oldpos + 28, this.transform.position.z);
        oldpos = oldpos + 28;
        leftwall.transform.position = new Vector3(this.transform.position.x, oldpos +0.1f, leftwall.transform.position.z);
        rightwall.transform.position = new Vector3(this.transform.position.x, oldpos - 0.8f, rightwall.transform.position.z);
        gameObject.GetComponent<Collider2D>().enabled = true;
        gameObject.GetComponent<SpriteRenderer>().sprite = candy;
        gameObject.transform.localScale = new Vector3(0.935423f, 0.935423f, 0.935423f);
    }

    void FixedUpdate()
    {

        if (collidedleft)
        {


            // rigidbody2D.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -0.2f, 0);

        }
        if (collidedright)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0.2f, 0);
            // rigidbody2D.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }   
        if (bubble.transform.position.y - this.transform.position.y > 4)
        {
            this.transform.position = new Vector3(randomElementPositionX[Random.Range(0, 3)], oldpos + 28, this.transform.position.z);
            oldpos = oldpos + 28;
            leftwall.transform.position = new Vector3(this.transform.position.x, oldpos + 0.1f, leftwall.transform.position.z);
            rightwall.transform.position = new Vector3(this.transform.position.x, oldpos - 0.8f, rightwall.transform.position.z);
        }




       


   




    }

    float RandomElementRange(float index_1, float index_2)
    {
        float index;
        index = Random.Range(index_1, index_2);
        index = Mathf.RoundToInt(index);
        return index;
    }


}
