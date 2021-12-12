using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using System.Collections.Generic;


public class Player : MonoBehaviour {

	// initialize the viables
    public Transform player; 

	// different specs for health and stuff
	public HealthBar healthBar;
	public int maxHealth = 100;
	public int currentHealth;
	public int damage = 10;

	// bool to tell if you have picked up the boss item or not
	public static bool hasBossItem;

	// variables for throwing item
	float throwForce = 150;
	Transform itemRotation;

	// reference other objects from here to avoid having issues with other
	// objects randomly assigned
	Transform itemSpot;
	GameObject bossItem;
	GameObject indicator;


	void Start (){
		// initializing the starting point of our variables
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
		hasBossItem = false;
		bossItem = GameObject.FindWithTag("BossItem");
		indicator = GameObject.FindWithTag("Indicator");
		itemSpot = GameObject.FindWithTag("ItemSpot").transform;
	}

	// this is the code for sending the boss item to where it needs to go
	void Update(){
		if (Input.GetKey("f") && hasBossItem)
		{
			// turn off boss item indicator and turn on the boss item
			indicator.SetActive(false);
			bossItem.SetActive(true);

			// update the colllider and rigidbody 
			bossItem.GetComponent<Collider>().isTrigger = false;
			bossItem.GetComponent<Rigidbody>().isKinematic = false;
	
			// transform it to in front of the player
			bossItem.transform.position = (itemSpot.position);
			bossItem.GetComponent<Rigidbody>().AddForce(player.transform.forward * throwForce);
		}
	}


	// checks for the collision for damage
	void OnCollisionEnter(Collision other)
	{
		// if the collision is just a plain enemy then lower damage
		if (other.gameObject.CompareTag("Enemy"))
		{
			TakeDamage(10);
		}
		// if the collision is a boss then half damage is gone
		else if (other.gameObject.CompareTag("BossCollider"))
		{
			TakeDamage(50);
		}
		// but if the collision is a health icon then gain 20 health back
		else if (other.gameObject.CompareTag("HealthUp"))
		{
			GetHealth(10);
			Destroy(other.gameObject);
		}
	}


	// reduces health
	void TakeDamage(int damageTaken)
	{
		// decrease health as damanage is taken and then lower the health bar
		currentHealth -= damageTaken;
		healthBar.SetHealth(currentHealth);

		// check to see if you run out of health and if you do then the scene goes to game over
		// you can choose to restart this level from there or not
		if (currentHealth <= 0)
		{
			SceneManager.LoadScene("GameOverScene");
		}
	}

	// gains health back
	void GetHealth(int healthGotten)
	{
		// adds the healthGotten amount to the current health but if it is higher than
		// the max health then it just sets it to the max health
		currentHealth += healthGotten;
		
		if (currentHealth > maxHealth )
		{
			currentHealth = maxHealth;
		}

		healthBar.SetHealth(currentHealth);
	}
}
