﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPDOWN : MonoBehaviour {
	private bool collided = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D coll)
    {
		if (coll.tag == "Player" && coll.isTrigger && collided == false)
        {
			collided = true;
			coll.GetComponent<PlayerHealth>().AddMaxHealth(-1);
			Destroy(gameObject);
        } 
    }
}