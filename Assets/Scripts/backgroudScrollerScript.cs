using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class backgroudScrollerScript : MonoBehaviour {
    public float speed1= 0;
    public float speed2 = 0;
    public static backgroudScrollerScript current;
    float pos1 = 0;
    float pos2 = 0;
    public Texture[] textures;
    int TextureIndex=0;
	// Use this for initialization
	void Start () {
        current = this;
        if (textures.Length == 0)
            return;

        TextureIndex = PlayerPrefs.GetInt("TextureSky", 0);
       /* switch (TextureIndex)
        {

            case 0:

                GetComponent<Renderer>().material.mainTexture = textures[0];
                PlayerPrefs.SetInt("TextureSky", 1);
                break;
            case 1:
                  GetComponent<Renderer>().material.mainTexture = textures[1];
                PlayerPrefs.SetInt("TextureSky", 2);
                break;
            case 2:
                  GetComponent<Renderer>().material.mainTexture = textures[2];
                PlayerPrefs.SetInt("TextureSky", 3);
                break;
            case 3:
                  GetComponent<Renderer>().material.mainTexture = textures[3];
                PlayerPrefs.SetInt("TextureSky", 4);
                break;
            case 4:
                  GetComponent<Renderer>().material.mainTexture = textures[4];
                PlayerPrefs.SetInt("TextureSky", 5);
                break;
            case 5:
                  GetComponent<Renderer>().material.mainTexture = textures[5];
                PlayerPrefs.SetInt("TextureSky", 6);
                break;
            case 6:
                  GetComponent<Renderer>().material.mainTexture = textures[6];
                PlayerPrefs.SetInt("TextureSky", 7);
                break;
            case 7:
                  GetComponent<Renderer>().material.mainTexture = textures[7];
                PlayerPrefs.SetInt("TextureSky", 0);
                break;
        }
        */
       
	}
	
	// Update is called once per frame
	void Update () {
   
        pos1 += speed1;
        if (pos1 > 1.0f)
        
            pos1 -= 1.0f;
      
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(pos1, 0);
           
           
	}
 public   void Go()
    {

        pos2 += speed2;
        if (pos2 > 1.0f)

            pos2 -= 1.0f;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, pos2);


    }
}
