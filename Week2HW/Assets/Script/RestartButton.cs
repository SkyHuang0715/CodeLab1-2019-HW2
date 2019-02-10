using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
	private GameObject enemy1;

	private GameObject button;
	// Use this for initialization
	void Start ()
	{
		enemy1 = GameObject.Find("enemy");
		button = GameObject.Find("Restart");
	}
	
	// Update is called once per frame
	void Update () {
		
		
			if(enemy1.GetComponent<EnemyFollow>().gameOver)  //the button only shows up when game is over
		{
			button.SetActive(true); 
		}
			else
			{
				button.SetActive(false); 
			}
		
		
	}
}