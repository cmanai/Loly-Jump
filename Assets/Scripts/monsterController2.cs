using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MonsterController2 : MonoBehaviour
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

        randomElementPositionX.Add(2f);

        randomElementPositionY.Add(8);
        randomElementPositionY.Add(16);
        randomElementVelocity.Add(0.034f);
        randomElementVelocity.Add(0.04f);
        randomElementVelocity.Add(0.044f);
        randomElementVelocity.Add(0.07f);
        randomElementVelocity.Add(0.03f);
        position = randomElementPositionX[Random.Range(0, 2)];
        velocity = randomElementVelocity[Random.Range(0, 5)];
        transform.position = new Vector3(position, transform.position.y, transform.position.z);
    }

    // Update is called once per frame




    void OnCollisionEnter2D(Collision2D collision)
    {

    }




    void FixedUpdate()
    {


       


    }

    float RandomElementRange(float index_1, float index_2)
    {
        float index;
        index = Random.Range(index_1, index_2);
        index = Mathf.RoundToInt(index);
        return index;
    }


}
