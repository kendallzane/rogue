using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	
	private Vector2 movement;
	private float hInput, vInput;
	private Rigidbody2D rb;
	public float speed = 2.0f;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		hInput = Input.GetAxisRaw ("Horizontal");
		vInput = Input.GetAxisRaw ("Vertical");
		movement = new Vector2 (hInput, vInput).normalized * speed;
		rb.AddForce(movement);
	}
}
