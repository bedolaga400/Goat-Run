using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoremanageer : MonoBehaviour
{
    public int score;
    public int highscore;
    public Text scoreDisplay;
    public Text scorehighDisplay;



    private void Update() 
    {
        highscore = (int)score;
        scoreDisplay.text = "" + highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
        {
            PlayerPrefs.SetInt("score", highscore);
        }
        scorehighDisplay.text = "" + PlayerPrefs.GetInt("score").ToString();
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Barrier"))
        {
            score++;
        }
    }
}
