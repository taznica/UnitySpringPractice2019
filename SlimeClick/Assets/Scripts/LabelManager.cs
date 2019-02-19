using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabelManager : MonoBehaviour {

	public Text timerLabel;
	public float timer = 20.0f;

	public Text countLabel;
	public float slimeCount = 0.0f;

	bool isTwoTimes = false;
	public GameObject slime;
	public GameObject twoTimeButton;

	// Use this for initialization
	void Start() {
		
	}
	
	// Update is called once per frame
	void Update() {
		if (timer >= 0.0f) {
			timer -= Time.deltaTime;
		}

		if (Input.GetMouseButtonDown(0)) {
			slimeCount++;

			if (isTwoTimes == true) {
				slimeCount++;
				Instantiate(slime, new Vector3 (0, 10, 0), Quaternion.identity);
			}

			Debug.Log(slimeCount);
		}

		if (timer <= 10.0f) {
			twoTimeButton.SetActive(true);
		}

		timerLabel.text = timer.ToString("f1");
		countLabel.text = slimeCount.ToString("f0");
	}

	public void OnClick() {
		isTwoTimes = true;
	}
}
