using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Analytics;

public class winning : MonoBehaviour
{

    public GameObject Player;
    private GameObject finish;

    public Text finishString;

    public Text Score;

    private PlayerController user1;
    // Start is called before the first frame update
    void Start()
    {
        user1 = Player.GetComponent<PlayerController>();
        finish= GameObject.Find("GameController"); 
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "" + user1.score;
        
        
        
        if (user1.score >= 40)
        {
            finishString.gameObject.SetActive(true);
            String text = "";

            text = "You Win!";
            finishString.text = text;
         
        }

        
    }
}
