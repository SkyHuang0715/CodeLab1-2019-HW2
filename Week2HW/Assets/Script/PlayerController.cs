using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public KeyCode upKey; 
	public KeyCode downKey;
	public KeyCode leftKey;
	public KeyCode rightKey;
	
	public float forceAmount = 1;
	private Rigidbody2D rb;

	public int score = 0;

	public Vector2 jump;

	public bool isGrounded;
	//public float jumpForce = 2;

	
	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		jump = new Vector2(0, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector2 newForce = new Vector2(0,0); //the force we will add to our player

		if (Input.GetKey(upKey)) //When someone press "W"
		{
			//Debug.Log("Pressed W");
			newForce.y += forceAmount;
			
			
			
		}

		if (Input.GetKey(leftKey)) //When someone press "A"
		{
			//Debug.Log("Pressed A");
			newForce.x -= forceAmount;
		}

		if (Input.GetKey(downKey)) //When someone press "S"
		{
			//Debug.Log("Pressed S");
			newForce.y -= forceAmount;
		}

		if (Input.GetKey(rightKey)) //When someone press "D"	
		{
			//Debug.Log("Pressed D");
			newForce.x += forceAmount;
		}

		if (Input.GetKey(KeyCode.Space)&& isGrounded)
		{
			Debug.Log("Pressed Space");
			rb.AddForce(jump * forceAmount);
			isGrounded = false;
		}

		rb.AddForce(newForce);
	}
	
	
}
