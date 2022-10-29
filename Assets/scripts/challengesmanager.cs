using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class challengesmanager : MonoBehaviour
{



    //Managing challenges 
    public GameObject[] challenges;//array of challenges
    //[Range(-20f, 20f)]
    //public float scrollspeed = 7.5f;// speed of challenges 
    [Range(7.5f, 15f)]
    public float scrollspeedvarry;// speed of challenges will be increasing time by time
    public Transform challengesspawnpoint;//the point from where our challenges start coming 
    public float counter = 0f; // after what time our challenges will come
    public Button watchaddbtn;
    public UImanager uimanager;


    void Start()
    {
        generatechallenges();
    }


    void Update()
    {
        if (counter <= 0)
        {
            generatechallenges();
        }
        else
        {
            counter -= Time.deltaTime;
        }

        GameObject CurrentChild;
        for (int i = 0; i < transform.childCount; i++)
        {
            CurrentChild = transform.GetChild(i).gameObject;
            scrollchallenge(CurrentChild);

            if (CurrentChild.transform.position.x <= -25f || uimanager.watchadsbtn.enabled == true)
            {
                Destroy(CurrentChild);
            }
        }

    }
    public void generatechallenges()
    {
        GameObject newchallenge = Instantiate(challenges[Random.Range(0, challenges.Length)], challengesspawnpoint.position, Quaternion.identity);
        newchallenge.transform.parent = transform;

        counter = 4f;
    }

    void scrollchallenge(GameObject currentchallenge)
    {
        if (Time.timeScale == 1f && scrollspeedvarry <= 10)
        {
            scrollspeedvarry += 0.00008f;
        }
        currentchallenge.transform.position += Vector3.left * scrollspeedvarry * Time.deltaTime;
    }





}
