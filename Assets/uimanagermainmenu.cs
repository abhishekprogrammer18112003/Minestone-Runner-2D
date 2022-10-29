using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uimanagermainmenu : MonoBehaviour
{
    public GameObject mainmenupannel;
    public GameObject creditspannel;
    public GameObject settingpannel;
    public GameObject loadingpannel;
    public Button settingbtn;

    public AudioSource btnaudio;
    // public Text highscoretext;
    // public int highscore = int.Parse(scoremanager.instance.highestscoretext.text);



    void Start()
    {
        // highscore = PlayerPrefs.GetInt("highscore", int.Parse(scoremanager.instance.highestscoretext.text));
        // highscoretext.text = highscore.ToString();

        Time.timeScale = 1f;
        settingbtn.enabled = true;
        mainmenupannel.SetActive(true);
        creditspannel.SetActive(false);
        settingpannel.SetActive(false);
        loadingpannel.SetActive(false);
    }


    void Update()
    {
    }


    public void playbtnclicked()
    {
        mainmenupannel.SetActive(false);
        loadingpannel.SetActive(true);
        Invoke("gameplay", 3f);
        btnaudio.Play();

    }
    public void gameplay()
    {
        SceneManager.LoadScene("gamescene");
    }


    public void creditbtnclicked()
    {
        settingbtn.enabled = false;
        creditspannel.SetActive(true);
        btnaudio.Play();
    }

    public void settingbtnclicked()
    {
        settingbtn.enabled = false;
        settingpannel.SetActive(true);
        btnaudio.Play();

    }

    public void crossbtnclicked()
    {
        settingbtn.enabled = true;
        mainmenupannel.SetActive(true);
        creditspannel.SetActive(false);
        settingpannel.SetActive(false);
        loadingpannel.SetActive(false);
        btnaudio.Play();

    }


    public void quitbtnclicked()
    {
        Application.Quit();
        btnaudio.Play();
    }





    //url opening 


    public void facebook()
    {
        Application.OpenURL("https://www.facebook.com/profile.php?id=100067987196786");
    }
    public void instagram()
    {
        Application.OpenURL("https://www.instagram.com/storywoodstudio/");
    }

    public void youtube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UC7we8Am2QZLTjQFZK1LMPDg");
    }






}
