using UnityEngine;
using System.Collections;

public class FadeScript : MonoBehaviour {
    public Texture2D fadeouttexture;
    public float fadespeed = 1f;
    private int drawdepth = -1000;
    private float alpha = 1.0f;
    private int dir = -1;

    void OnGUI()
    {

        alpha += dir * fadespeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawdepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeouttexture);

    }
    public float BeginFade(int direction)
    {
        dir = direction;
        return (fadespeed);
    }
    void OnLevelWasLoaded()
    {

        BeginFade(-1);
    }
}
