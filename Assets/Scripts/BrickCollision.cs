using UnityEngine;
using System.Collections;

public class BrickCollision : MonoBehaviour {

	int numberOfTimesHit; 
	public int MaxHits; 

	LevelManager levelManager; 

	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>(); 
		numberOfTimesHit = 0; 
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		numberOfTimesHit++; 
		if(numberOfTimesHit == MaxHits)
		{
			Destroy(gameObject); 
			SimulateWin();
		}



	}

	
	// Update is called once per frame
	void Update () {
		print("Hello"); 
	}

	void SimulateWin()
	{
		Application.LoadLevel(Application.loadedLevel + 1); 
	}
}
