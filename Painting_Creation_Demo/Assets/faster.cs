using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faster : MonoBehaviour {


	public bool speedUpTime = false;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (speedUpTime) {
				Time.timeScale = 1.0f;
				speedUpTime = false;
			} else if (!speedUpTime) {
				Time.timeScale = 3;

				speedUpTime = true;
			}
		}

	}
}
