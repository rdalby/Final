using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using System.Collections.Generic;

public class EnemiesMovement : MonoBehaviour {
	// player, enemey script is attached to, and bossitem
     public Transform player;
	 public GameObject enemy;
	 Transform enemyTransform;
	 public Transform bossItem;
	
	// checks for boss and if item has been gotten
	 public bool hasItem = false;
	 public bool isBoss = false;

	 // movement and rotation speeds need to match or doesn't
	 // go smooth. Range and stop for when to move and stop
	 int rotationSpeed = 3;
     int moveSpeed = 4;
	 public float range = 10f; 
	 public float stop = 8;

	 // the animator for the enemy to move the parameters to different
	 // animations depending on the items
 	public Animator m_Animator;

	// grabs the animator and calls awake - I added this in because the 
	// awake function doesn't consistently call without it
	void Start (){
		m_Animator = GetComponent<Animator>();

		if (enemy.gameObject.CompareTag("Boss"))
		{
			isBoss = true;
		}
		Awake();
	}

	// gets the position of the player, bossitem, and itself (enemy)
	 void Awake()
 	{
		player = GameObject.FindWithTag("Player").transform; 
		bossItem = GameObject.FindWithTag("BossItem").transform;
		enemyTransform = transform;
 	}

 

	void Update () {    
	
		// rotate to look at which on is in range
		float playerDistance = Vector3.Distance(enemyTransform.position, player.position);
		float itemDistance = Vector3.Distance(enemyTransform.position, bossItem.position);

		// check to see if they are the boss and if they are if they have the item. If they are not
		// the boss or they are the boss without the item then move. If they are the boss with the item
		// then do nothing.
		if ((!hasItem && isBoss) || !isBoss)
		{
			// check to see if the boss item is in range if it is then go after the item not the player
			if (itemDistance <= range)
			{
					movement(itemDistance, bossItem);
			} 
			else if (playerDistance <= range)
			{
					movement(playerDistance, player);
			}	
		}

	}

	// making this generic so that I don't have to have a lot of if statements with the same follow code put in 
	void movement (float distance, Transform thingToChase)
	{
		// adjusts the animator's distance variable to be used wiht the animator for when the player is close or far tranistions
		m_Animator.SetFloat("distance", distance);
		
		// put the move before the rotation or you end up with a ton of spinning animations this is something that I need to come back to
		// ideally
		
		//look around and move functions
		// if the object is in range then go to the object rather then the character
		
		// move towards the character
		enemyTransform.rotation = Quaternion.Slerp(enemyTransform.rotation, 
			Quaternion.LookRotation(thingToChase.position - enemyTransform.position), rotationSpeed*Time.deltaTime);
		
		//move
		if(distance>stop)
		{
			enemyTransform.position += enemyTransform.forward * moveSpeed * Time.deltaTime;
		}
			
	}

}
