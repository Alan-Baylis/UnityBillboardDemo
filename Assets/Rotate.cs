using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class Rotate : MonoBehaviour {

	public float rate = 5f;
	
	void Update() {
		this.transform.rotation = Quaternion.Euler(0, rate * Time.time, 0f);
	}
}
