using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BackGroundScroller2 : MonoBehaviour
{
    public float speed1 = 0;
    public float speed2 = 0;
    public static BackGroundScroller2 current;
    float pos1 = 0;
    float pos2 = 0;
    public Texture[] textures;

    // Use this for initialization
    void Start()
    {
        current = this;
      
    }

    // Update is called once per frame
    void Update()
    {

        pos1 += speed1;
        if (pos1 > 1.0f)

            pos1 -= 1.0f;

        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(pos1, 0);


    }
    public void Go()
    {

        pos2 += speed2;
        if (pos2 > 1.0f)

            pos2 -= 1.0f;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, pos2);


    }
}
