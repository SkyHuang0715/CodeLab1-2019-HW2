using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour{

public Transform Player;
public Transform upBounds;
public Transform downBounds;

public float smoothDampTime = 0.15f;
private Vector3 smoothDampVelocity = Vector3.zero; 

private float camWidth, camHeight, levelMinY, levelMaxY;



    // Start is called before the first frame update
    void Start()
    {
        camWidth = Camera.main.orthographicSize * 2;
        camHeight = camWidth * Camera.main.aspect;

        float downBoundHeight = downBounds.GetComponentInChildren<Renderer>().bounds.size.y / 2;
        float upBoundHeight = upBounds.GetComponentInChildren<Renderer>().bounds.size.y / 2;
//when the camera reaches the up or down bounds, it won't keep moving. 
//camera only move up and down
        levelMinY = downBounds.position.y + downBoundHeight + (camHeight / 2);
        levelMaxY = upBounds.position.y - upBoundHeight - (camHeight / 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
            float PlayerY = Mathf.Max(levelMinY, Mathf.Min(levelMaxY, Player.position.y));
            //When the player approaches the target position y, camera's position will constantly moves up
            
            float y = Mathf.SmoothDamp(transform.position.y, PlayerY, ref smoothDampVelocity.y, smoothDampTime);
            //from position to target in a specific time
            
            transform.position = new Vector3(transform.position.x, Player.position.y, -10);
        
        
    }
}
