using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	private Paddle paddle; 

	bool hasStarted = false; 

	Vector3 paddleToBallDifference; 

	// Use this for initialization
	void Start () {

		paddle = GameObject.FindObjectOfType<Paddle>(); 

		paddleToBallDifference = this.transform.position - paddle.transform.position; 
		Debug.Log("paddle to ball difference value is " + paddleToBallDifference); 
	}
	
	// Update is called once per frame
	void Update () {
		if(!hasStarted){
			this.transform.position = paddle.transform.position + paddleToBallDifference; 
		}

		if (Input.GetMouseButtonDown(0)){
			hasStarted = true;
			this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f); 
		}
			
	}
}
