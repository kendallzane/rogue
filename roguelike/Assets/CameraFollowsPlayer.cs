﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsPlayer : MonoBehaviour {
    
	public GameObject player;
	private Vector3 offset;
	
	// Use this for initialization
	void Start () {
		//transform.position = player.transform.position - new Vector3(0f, 0f, 10f);
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called after Update each frame
	
    void LateUpdate () 
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
    }
	
}
