using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using System.Collections.Generic;


public class BossItem : MonoBehaviour {

	public GameObject item;
	public bool inTrigger;
	public Transform itemParent;

	public GameObject bossObject;
	Animator bossAnimator;
	public Collider m_ObjectCollider;
	public Rigidbody m_ObjectRigid;
	GameObject indicator;

	public GameObject itemPopUpWindow;


	// Use this for initialization
	void Start () 
	{
		// initialize the variables	
		inTrigger = false;
		m_ObjectCollider = GetComponent<Collider>();
		m_ObjectRigid = GetComponent<Rigidbody>();
		indicator = GameObject.FindWithTag("Indicator");
		indicator.SetActive(false);
	}


	void Awake() {
		// set the boss animator/object on wake
		bossObject = GameObject.FindWithTag("Boss");
		bossAnimator = bossObject.GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider other) {
		// checks to see what object collided with it. 
		// if it's the boss then it does the boss related updates
		// sets the boss animation parameter for hasItem to true
		// this allows the animations of the trex to line up properly
		if (other.gameObject.CompareTag("BossCollider"))
		{
			Awake();
			bossAnimator.SetBool("hasItem", true);
			PopCan.bossHasItem = true;
		}
	} 

	// next to allow for the input controls for picking up the item
	void OnTriggerStay(Collider other)
	{
		// checks for if it's the player
		if (other.gameObject.CompareTag("Player")) 
		{	
			// if the enter/return is pressed then the object is picked up
			inTrigger = true;
			itemPopUpWindow.SetActive(true);
			if (Input.GetKey("return"))
			{
				PickUpObject();
			}
		}
		
	}

	void OnTriggerExit(Collider other)
	{
		// if it's the player exiting the trigger
		if (other.gameObject.CompareTag("Player")) 
		{	
			itemPopUpWindow.SetActive(false);
			// sets everything back to what it was before you entered the trigger
			inTrigger = false;
			m_ObjectCollider.isTrigger = false;
			m_ObjectRigid.isKinematic = false;
		}
		
	}

	void OnCollisionEnter(Collision other) {
		// checks to see what object collided with it. 
		// then turns to trigger and kinematic on if boss or player
		if (other.gameObject.CompareTag("BossCollider") || other.gameObject.CompareTag("Player"))
		{
			m_ObjectCollider.isTrigger = true;
			m_ObjectRigid.isKinematic = true;
		}
	} 
	

	// the function for "picking up" the item
	void PickUpObject()
	{
		// sets the variable in the player script to true so that it's update function can work
		Player.hasBossItem = true;

		// sets the item indicator to active on your heads up display
		indicator.SetActive(true);
		
		// makes the item inactive until the player throws it
		// went this route because the physics with carrying the item and collisions made it 
		// difficult to carry and throw away properly
		item.SetActive(false);
		itemPopUpWindow.SetActive(false);
		
	}
}
