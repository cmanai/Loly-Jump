using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CandyScript : MonoBehaviour
{

    static int Current_nb_candy = 0;
    static int Total_nb_candy = 0;
    Text instruction;


    static public void AddPoint()
    {

        Current_nb_candy++;

     
    }



    void Start()
    {


        instruction = GetComponent<Text>();

        Current_nb_candy = 0;
        Total_nb_candy = PlayerPrefs.GetInt("Total_Candy", 0);
        Debug.Log(Total_nb_candy + " this is the total of candys");
        var Total_score = PlayerPrefs.GetInt("highScore", 0);
        Debug.Log(Total_score + " this is highscore");
    }

    void OnDestroy()
    {

        PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);
        PlayerPrefs.SetInt("Total_Candy", Current_nb_candy+Total_nb_candy);
       
    }

    void Update()
    {
        PlayerPrefs.SetInt("CurrentCandy", Current_nb_candy);
        PlayerPrefs.SetInt("Total_Candy", Current_nb_candy + Total_nb_candy);
    
        instruction.text = "x " + Current_nb_candy;


    }
}
