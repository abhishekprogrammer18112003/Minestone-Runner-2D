using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour
{
    public GameObject gameoverpannel;
    public static scoremanager instance;
    public Text scoretext;
    public Text highestscoretext;
    public Text myscore;
    int score = 0;
    int highscore = 0;
    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {

        myscore.text = scoretext.text;
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoretext.text = score.ToString();
        highestscoretext.text = highscore.ToString();


    }





    public void addpoint()
    {
        score += 1;
        scoretext.text = score.ToString();
        myscore.text = scoretext.text;

        if (highscore <= score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }





}
