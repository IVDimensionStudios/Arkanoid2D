using UnityEngine;
using System.Collections;

public class MyCollider : MonoBehaviour {

	public LevelManager levelManager;

	void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("Collision is occuring"); 
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log("Trigger is occuring"); 
		levelManager.LoadLevel("LossMenu"); 
	}
}
