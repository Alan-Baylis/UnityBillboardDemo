using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class FadeAlphaByDistance : MonoBehaviour {

	// min and max distance from camera objects can be
	// discovered by logging "distance" from Update()
	public float minDistance = 10f;
	public float maxDistance = 20f;

	Text text;

	void Start() {
		text = this.GetComponent<Text>();
	}
	
	void Update() {
		Vector3 camPos = Camera.main.transform.position;
		Vector3 dist = this.transform.position - camPos;

		Debug.DrawRay(camPos, dist, Color.red);

		float distance = dist.magnitude;
//		Debug.Log(distance);

		float alpha = 1f - ((distance-minDistance) / (maxDistance-minDistance));
//		Debug.Log(alpha);

		Color color = text.color;
		color.a = alpha;
		text.color = color;
	}
}
