using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		//Mathf.Clamp()

	    Vector3 paddlePos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
		float mousePositionX = Input.mousePosition.x / Screen.width * 16;
		mousePositionX = Mathf.Clamp(mousePositionX, 0.5f , 15.5f); 
		Debug.Log(mousePositionX);

		paddlePos.x = mousePositionX; 

		this.transform.position = paddlePos;

		//float mousePositionX = Input.mousePosition.x; 
		//Vector3 currentPosition = new Vector3(mousePositionX, this.transform.position.y, this.transform.position.z );
		//this.transform.position = currentPosition; 
	}
}
