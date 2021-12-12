using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using System.Collections.Generic;


public class Enemies : MonoBehaviour {

	public int health;
	public int maxHealth = 100;

	public int currentHealth;
	public int damage = 10;

	public HealthBar healthBar;
     public Transform player; 
	 public Transform enemyTransform; 

 	public Animator m_Animator;

	void Start (){
		m_Animator = GetComponent<Animator>();
		Awake();
	}

	void Init() {

	}

	void Movement () {

	}


	// the following makes the enemies follow the player if they are in range
 void Awake()
 {
	 // target the player
     player = GameObject.FindWithTag("Player").transform; 
	 
	 // putting in the transform to help with speed
     enemyTransform = transform;
 }

 

 void Update () {    
	
 }





	void Attack () {

	}


	void TakeDamage(int damageTaken)
	{
		// decrease health as damage is taken and then lower the health bar
		currentHealth -= damageTaken;
		healthBar.SetHealth(currentHealth);
	}

}
