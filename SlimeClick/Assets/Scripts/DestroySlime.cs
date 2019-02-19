using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySlime : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (this.gameObject.transform.position.y <= -30.0f){
            Destroy(this.gameObject);
        }
	}
}
