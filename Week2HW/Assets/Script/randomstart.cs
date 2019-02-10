using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class randomstart : MonoBehaviour


{
	// Start is called before the first frame update
	void Start()
	{
		//gameOver = false;
		//Spawn();

		Invoke("Spawndart", 1);
	}

	// Update is called once per frame
	void Update()
	{

	}

	void Spawndart()
	{
		for (int i = 0; i < 4; i++)
		{
			GameObject newPrize = Instantiate(Resources.Load<GameObject>("Prefab/dart"));
			newPrize.transform.position = new Vector2(Random.Range(-8, 11), Random.Range(-2, 45));
		}
	}
}
