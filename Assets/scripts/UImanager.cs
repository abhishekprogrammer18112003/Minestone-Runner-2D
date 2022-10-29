using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{





    //Background movement 
    [Range(-1f, 1f)]
    public float scrollSpeed = 0.5f;
    public Material mat;
    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        Time.timeScale = 0f;
        scoretext.enabled = false;
        restartbtn.image.enabled = false;
        resumebutton.image.enabled = false;
        gameoverpannel.SetActive(false);
        doyouwanttoexitpannel.SetActive(false);
        resumetext.enabled = false;
        watchadsbtn.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(scrollSpeed, 0);
        mat.mainTextureOffset += offset * Time.deltaTime;



    }






    //gameover pannel manager

    public GameObject gameoverpannel;
    public GameObject doyouwanttoexitpannel;
    public gamecontroller gamecontroller;
    public Button watchadsbtn;
    public void showgameoverpannel()
    {
        Time.timeScale = 0f;
        gameoverpannel.SetActive(true);
        scoretext.enabled = false;
        restartbtn.image.enabled = false;
        resumebutton.image.enabled = false;
        watchadsbtn.enabled = true;

    }



    // managing UI


    public Text scoretext;
    public Button restartbtn;
    public Button resumebutton;
    public Text resumetext;



    public void restartbtnclicked()
    {
        Time.timeScale = 0f;
        gamecontroller.enabled = false;
        scoretext.enabled = false;
        restartbtn.enabled = false;
        resumebutton.enabled = false;
        doyouwanttoexitpannel.SetActive(true);
        bgaudiomanager.instance.btnclickaudio.Play();


    }

    public void yesbtnclick()
    {
        SceneManager.LoadScene("mainmenuscene");
        bgaudiomanager.instance.btnclickaudio.Play();
    }
    public void nobtnclicked()
    {
        Time.timeScale = 1f;
        gamecontroller.enabled = true;
        scoretext.enabled = true;
        restartbtn.enabled = true;
        resumebutton.enabled = true;
        doyouwanttoexitpannel.SetActive(false);
        bgaudiomanager.instance.btnclickaudio.Play();
    }






    public void resumebuttonclicked()
    {
        Time.timeScale = 0f;
        resumebutton.image.enabled = false;
        resumetext.enabled = true;
        gamecontroller.taptostartbtnclick();
        bgaudiomanager.instance.btnclickaudio.Play();



    }


    public void gameoverrestartbtnclicked()
    {
        SceneManager.LoadScene("gamescene");
        bgaudiomanager.instance.btnclickaudio.Play();
    }

    public void gameovercrossbtnclick()
    {
        Time.timeScale = 0f;
        doyouwanttoexitpannel.SetActive(false);
    }


    public void quitbtnclicked()
    {
        SceneManager.LoadScene("mainmenuscene");
    }




}
