using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour
{

    // tap to start alorithm

    public Text taptostart;
    public Text scoretext;
    public Button restartbtn;
    public Button resumebtn;
    public Text resumetext;


    void Start()
    {
        taptostart.enabled = true;


    }

    void Update()
    {
        taptostartbtnclick();
    }




    public void taptostartbtnclick()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            taptostart.enabled = false;
            scoretext.enabled = true;
            restartbtn.image.enabled = true;
            resumebtn.image.enabled = true;
            resumetext.enabled = false;
            Time.timeScale = 1f;

        }

    }







}
