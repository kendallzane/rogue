using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	private bool collided = false;
    void OnTriggerEnter2D(Collider2D coll)
    {
		
		if (coll.tag == "Enemy" && !collided)
        {
			collided = true;
            coll.GetComponent<Enemy>().TakeDamage(1);
        }
        if (coll.tag != "Player")
        {
			Destroy(gameObject);
        } 
    }
}
