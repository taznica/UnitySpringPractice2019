using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {

	public Text timeLabel;
	float timer = 0.0f;
	int flag = 0;

	// Use this for initialization
	void Start() {
		timeLabel.text = "StopGame";
	}
	
	// Update is called once per frame
	void Update() {
		if (flag == 1) {
			timer += Time.deltaTime;
			timeLabel.text = timer.ToString("f1");
			transform.localScale = new Vector3 (1, 1, 1) * timer * 0.1f;
		}
	}


	public void StartButton() {
		flag = 1;
		timer = 0.0f;
	}

	public void StopButton() {
		flag = 0;
		if (9.95f <= timer && timer <= 10.05f) {
			
			transform.localScale *= 2;
			GetComponent<Renderer>().material.color = Color.blue;
			timeLabel.text = "Awesome!";
		} else {
			timeLabel.text = "Booooo";
		}
		timer = 0.0f;
	}
}
