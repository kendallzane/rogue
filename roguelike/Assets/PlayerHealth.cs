using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
	public int currentHealth;
	public int maxHealth = 3;
	public Text healthText;
	
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		healthText.text = "Health: " + currentHealth + "/" + maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		healthText.text = "Health: " + currentHealth + "/" + maxHealth;
	}
	
	
}
