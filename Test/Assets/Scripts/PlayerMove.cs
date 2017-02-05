using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {


	Transform transform;
	float xMaxBoundary = 1;
	float xMinBoundary = -1;
	float yMaxBoundary = 1;
	float yMinBoundary = -1;



	// Use this for initialization
	void Start () {
		transform = GameObject.Find ("Player").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		#region keyboard
		if (Input.GetKeyDown (KeyCode.W) && transform.position.y < yMaxBoundary) {
			transform.position = new Vector2 (transform.position.x, transform.position.y + 1); 
		}
		if (Input.GetKeyDown (KeyCode.S) && transform.position.y > yMinBoundary) {
			transform.position = new Vector2 (transform.position.x, transform.position.y - 1); 
		}
		if (Input.GetKeyDown (KeyCode.D) && transform.position.x < xMaxBoundary) {
			transform.position = new Vector2 (transform.position.x + 1, transform.position.y); 
		}
		if (Input.GetKeyDown (KeyCode.A) && transform.position.x > xMinBoundary) {
			transform.position = new Vector2 (transform.position.x - 1, transform.position.y); 
		}
		#endregion


	}
}
