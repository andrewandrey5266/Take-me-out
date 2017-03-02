using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInput : MonoBehaviour {

	float maxTime = 0.5f;
	float minSwipeDist = 25f;

	float startTime;
	float endTime;

	Vector3 startPos;
	Vector3 endPos;
	float swipeDistance;
	float swipeTime;


	Transform transform;
	float xMaxBoundary = 1;
	float xMinBoundary = -1;
	float yMaxBoundary = 1;
	float yMinBoundary = -1;
	void Start () {
		transform = GameObject.Find ("Player").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
  			
			Touch touch = Input.GetTouch (0);

			if (touch.phase == TouchPhase.Began) {
				startTime = Time.time;
				startPos = touch.position;
			}
			else if (touch.phase == TouchPhase.Ended) {
				endTime = Time.time;
				endPos = touch.position;

				swipeDistance = (endPos - startPos).magnitude;
				swipeTime = endTime - startTime;

				if (swipeTime < maxTime && swipeDistance > minSwipeDist) {

					Swipe ();
				}
			}
		
		}

	}
	private void Swipe(){
		Vector2 distance = endPos - startPos;
		if (Mathf.Abs (distance.x) > Mathf.Abs (distance.y)) {
			// horizontal swipe
			Debug.Log ("horizontal swipe");

			if (distance.x > 0 && transform.position.x < xMaxBoundary)
				transform.position = new Vector2 (transform.position.x + 1, transform.position.y); 
			
			if (distance.x < 0 && transform.position.x > xMinBoundary)
				transform.position = new Vector2 (transform.position.x - 1, transform.position.y); 

		} else if (Mathf.Abs (distance.x) < Mathf.Abs (distance.y)) {
			// vertical swipe
			Debug.Log ("vertical swipe");

			if (distance.y > 0 && transform.position.y < yMaxBoundary)
				transform.position = new Vector2 (transform.position.x, transform.position.y + 1); 
			
			if (distance.y < 0 && transform.position.y > yMinBoundary)
				transform.position = new Vector2 (transform.position.x, transform.position.y - 1); 

		}
	}
}
