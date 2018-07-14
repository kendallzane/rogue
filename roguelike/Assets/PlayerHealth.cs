using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
	public int currentHealth;
	public int maxHealth = 3;
	public int maxHealthLimit = 10;
	
	public Text healthText;
	public GameObject HealthUI;
	public GameObject HealthFull;
	public GameObject HealthEmpty;
	
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		UpdateHealthUI();
	}
	
	// Update is called once per frame
	void Update () {
		//
	}
	
	public void UpdateHealthUI() {
		healthText.text = "Health: " + currentHealth + "/" + maxHealth;
		foreach (Transform child in HealthUI.transform) {
             Destroy(child.gameObject);
        }
		for (int i = 0; i < currentHealth; i++) {
			GameObject HF;
			HF = Instantiate(
            HealthFull,
            new Vector3(0f, 0f, 0f),
            transform.rotation) as GameObject;
			HF.transform.SetParent(HealthUI.transform);
			RectTransform RT = HF.GetComponent<RectTransform>();
			RT.localPosition = new Vector3(32 + (64 * i), -32, 0);
		}
		
		for (int i = currentHealth; i < maxHealth; i++) {
			GameObject HE;
			HE = Instantiate(
            HealthEmpty,
            new Vector3(0f, 0f, 0f),
            transform.rotation) as GameObject;
			HE.transform.SetParent(HealthUI.transform);
			RectTransform RT = HE.GetComponent<RectTransform>();
			RT.localPosition = new Vector3(32 + (64 * i), -32, 0);
		}
	}
	
	public void AddHealth(int toAdd) {
		if (currentHealth + toAdd >= maxHealth) {
			currentHealth = maxHealth;
		} else if(currentHealth + toAdd <= 0) {
			currentHealth = 0;
			//dead
		} else {
			currentHealth += toAdd;
		}
		UpdateHealthUI();
	}
	
	public void SetHealth(int toSet) {
		if (toSet >= maxHealth) {
			currentHealth = maxHealth;
		} else if (toSet <= 0) {
			currentHealth = 0;
			//dead
		} else {
			currentHealth = toSet;
		}
		UpdateHealthUI();
	}
	
	public void AddMaxHealth(int toAdd) {
		if (maxHealth + toAdd >= maxHealthLimit) {
			maxHealth = maxHealthLimit;
		} else if(maxHealth + toAdd <= 0) {
			maxHealth = 0;
			//dead
		} else {
			maxHealth += toAdd;
		}
		
		if (currentHealth > maxHealth) {
			currentHealth = maxHealth;
		}
		UpdateHealthUI();
	}
	
	public void SetMaxHealth(int toSet) {
		if (toSet >= maxHealthLimit) {
			maxHealth = maxHealthLimit;
		} else if (toSet <= 0) {
			maxHealth = 0;
			//dead
		} else {
			maxHealth = toSet;
		}
		
		if (currentHealth > maxHealth) {
			currentHealth = maxHealth;
		}
		UpdateHealthUI();
	}
}
