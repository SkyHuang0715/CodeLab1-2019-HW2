using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    		{
    	
    			
    	
    			//print("I GOT HIT");
    			if (other.gameObject.CompareTag("Player"))//if the collider attached the prize
    			{
	                other.gameObject.GetComponent<PlayerController>().score+= 10; //Get the PlayerController and add 10 score
    				Destroy(gameObject); //Destroy the gameObject I am attached to
    			}
    		}
}
