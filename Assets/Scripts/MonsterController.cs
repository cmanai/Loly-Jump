﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MonsterController : MonoBehaviour
{
    bool Dead;
    bool collided;
    // Drag your second sprite here
    public bool isGrounded = true;
    public GameObject bubble;
    private SpriteRenderer spriteRenderer;
    List<float> randomElementPositionX = new List<float>();
    List<float> randomElementPositionY = new List<float>();
    List<float> randomElementVelocity = new List<float>();
    float position;
float velocity = 0.06f;
    float time = 0.0022f;
    // Use this for initialization
    void Start()
    {
    
        randomElementPositionX.Add(-2.1f);
       
        randomElementPositionX.Add(2.1f);

        randomElementPositionY.Add(8);
        randomElementPositionY.Add(16);
        randomElementVelocity.Add(0.048f);
        randomElementVelocity.Add(0.045f);
        randomElementVelocity.Add(0.095f);
        randomElementVelocity.Add(0.085f);
        randomElementVelocity.Add(0.05f);
        position = randomElementPositionX[Random.Range(0, 2)];
 velocity = randomElementVelocity[Random.Range(0, 5)];
 transform.position = new Vector3(position, transform.position.y, this.transform.position.z);
    }

    // Update is called once per frame


 

    void OnCollisionEnter2D(Collision2D collision)
    {
     
    }




    void FixedUpdate()
    {


        if (bubble.transform.position.y - this.transform.position.y > 4)
        {
            this.transform.position = new Vector3(randomElementPositionX[Random.Range(0, 2)], this.transform.position.y + randomElementPositionY[Random.Range(0, 2)], this.transform.position.z);

            velocity = randomElementVelocity[Random.Range(0, 5)];
        }


        

        if (position >= 2f)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            collided = true;
        }
        if (position < -2f)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            collided = false;
        }


        if (collided == true)
        {

            if (time > 0)
                time -= Time.deltaTime;
            else
            {


                position -= velocity;
                time = 0.0022f;
                //  Debug.Log(position + "");
                transform.position = new Vector3(position, transform.position.y, this.transform.position.z);

            }
        }


        if (collided == false)
        {

            if (time > 0)
                time -= Time.deltaTime;
            else
            {


                position += velocity;
                transform.position = new Vector3(position, transform.position.y, this.transform.position.z);

              //  Debug.Log(position + "");
                time = 0.0022f;
                //	transform.position = new Vector2(position,0f);
            }
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