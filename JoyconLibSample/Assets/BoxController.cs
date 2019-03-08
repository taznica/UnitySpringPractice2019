using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour {

	private List<Joycon> joycons;
	private Joycon joycon;
//	private Joycon joyconL;
//	private Joycon joyconR;


	// Use this for initialization
	void Start () {
		joycons = JoyconManager.Instance.j;

		if (joycons == null || joycons.Count <= 0) {
			return;
		}

		joycon = joycons.Find(con => con.isLeft);
//		joyconL = joycons.Find(con => con.isLeft);
//		joyconR = joycons.Find(con => !con.isLeft);
	}
	
	// Update is called once per frame
	void Update () {
		if (joycons == null || joycons.Count <= 0) {
			return;
		}

		SynchronizeAnglesWithJoycon();

		MakeRambleWithKeyA();
	}

	private void SynchronizeAnglesWithJoycon(){
		var orientation = joycon.GetVector().eulerAngles;
		var angles = transform.localEulerAngles;

		angles.z = -orientation.y; // left and right viewed from the front 
		angles.y = orientation.z;  // horizontal(yoko) rotation viewed from the front
		angles.x = orientation.x;  // vertical(tate) rotation viewed from the front

		transform.localEulerAngles = angles;
	}

	private void MakeRambleWithKeyA(){
		if(Input.GetKeyDown(KeyCode.A)){
			StartCoroutine("SetRambleStrong");
		}
	}

	IEnumerator SetRambleStrong(){
		joycon.SetRumble(0, 500.0f, 1.0f, 50);
		yield return new WaitForSeconds(5.0f);
	}
}
