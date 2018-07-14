using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour {
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
			if (coll.GetComponent<PlayerHealth>().currentHealth < coll.GetComponent<PlayerHealth>().maxHealth) {
				collided = true;
				coll.GetComponent<PlayerHealth>().AddHealth(1);
				Destroy(gameObject);
			}
        } 
    }
}
