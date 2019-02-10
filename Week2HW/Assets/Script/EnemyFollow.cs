using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 



public class EnemyFollow : MonoBehaviour
{

	
//	[SerializeField] private Text uiText;
	
    public float speed;

    private Transform target;

    public bool gameOver;
    public Button Restart;
    

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();


    }


    // Update is called once per frame
    void Update()
    {

        if(Vector2.Distance(transform.position, target.position) > 1){
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            //make enemy from one position towards another position(from, to, speed)
            Time.timeScale = 1;
        }

        if (Vector2.Distance(transform.position, target.position) <= 1)
        {
            GameOver();
          
        }
        
             
    }
    
    public void Resetbtn()
    	{
    		if (!gameOver)
    		{
    			
	            //gameObject.SetActive(false); 
    			Restart.interactable = !Restart.interactable;
    		}

    		SceneManager.LoadScene(1);  
    		Time.timeScale = 1;
            gameOver = false;


        }
    	
    	void GameOver()
        	{
        		Time.timeScale = 0;
        		gameOver = true;
        		
        	}
        		
    	
}
    

   