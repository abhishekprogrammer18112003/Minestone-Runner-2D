using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbehaviour : MonoBehaviour
{

    public Rigidbody2D myrigidbody;
    public float jumppower;
    bool isjump = false;
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();

    }


    void Update()
    {



        if (isjump)
        {
            myrigidbody.AddForce(Vector2.up * jumppower * Time.deltaTime * myrigidbody.mass * myrigidbody.gravityScale);
        }






    }
    public void pointerdown()
    {
        isjump = true;
    }
    public void pointerup()
    {
        isjump = false;
    }




    public UImanager UImanager;

    public AudioSource coinsaudio;
    public AudioSource gameover;
    public gamecontroller gamecontroller;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "obstacles")
        {

            UImanager.showgameoverpannel();
            gamecontroller.enabled = false;
            gameover.Play();
        }

    }


    public void pausegame()
    {
        Time.timeScale = 0f;

    }

    public void OnTriggerEnter2D(Collider2D points)
    {
        if (points.gameObject.tag == "collectables")
        {
            scoremanager.instance.addpoint();
            Destroy(points.gameObject);
            coinsaudio.Play();

        }
    }



}
