using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	private bool looking = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!looking) {
			return;
		}
		int numEnemies = 0;
		foreach (Transform child in transform.parent) {
			if (child.gameObject.tag == "Enemy") {
				numEnemies++;
			}
		}
		if(numEnemies <= 0) {
			gameObject.SetActive(false);
			looking = false;
		}
	}
}
