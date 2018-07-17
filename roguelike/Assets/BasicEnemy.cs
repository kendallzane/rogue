using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : Enemy {
	//private bool collided = false;
	public float health = 3;	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D coll)
    {
		/*if (coll.tag == "Player" && coll.isTrigger && collided == false)
        {
			collided = true;
			coll.GetComponent<PlayerHealth>().AddHealth(-1);
			Destroy(gameObject);
        } 
		*/
    }
	
	public override void TakeDamage (int damage) {
		health -= damage;
		if (health <= 0) {
			Destroy(gameObject);
		}
	}
}
