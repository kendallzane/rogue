using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	public GameObject Bullet;
	public float bulletSpeed = 10f;
	public float bulletFireRate = 0.25f;
	public float shootCooldown;

	// Use this for initialization
	void Start () {
		shootCooldown = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (shootCooldown > 0f) {
			shootCooldown -= Time.deltaTime;
		} else {
			if (Input.GetMouseButton(0)) {
				shootCooldown += bulletFireRate;
				Vector2 cursorInWorldPos = (Camera.main.ScreenToWorldPoint(Input.mousePosition));
				cursorInWorldPos += new Vector2(0.5f, -0.5f);
				Vector2 shootDirection = (cursorInWorldPos - new Vector2(transform.position.x, transform.position.y)).normalized;
				if (shootDirection == new Vector2(0f, 0f)) {
					shootDirection = new Vector2(1f, 0f);
				}
		
				GameObject Projectile;
				Projectile = Instantiate(
					Bullet,
					transform.position + new Vector3(0f, 0f, 1f),
					transform.rotation) as GameObject;
				Projectile.GetComponent<Rigidbody2D>().velocity = shootDirection * bulletSpeed;
				Destroy(Projectile, 4.0f);
			}
		}
		
		
	}
}
