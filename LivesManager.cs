using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    //public GameObject playerInst;
    public int Lives = 3;

    public void UpdateLives()
    {
        GetComponent<Text>().text = "Lives: " + Lives;
    }
    //void Start()
    //{
       
    //}

    //// Update is called once per frame
    void Update()
    {
        //if (Dead == true)
        //{
        //    GameObject.Instantiate(playerInst);
        //    Dead = false;
        //    Lives -= 1;
        //}
        //UpdateLives();
    }


}
