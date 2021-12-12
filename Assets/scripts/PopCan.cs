using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class PopCan : MonoBehaviour {

	public GameObject popUpWindow;
	public GameObject popCan;
	public GameObject boss;
	public static bool bossHasItem;
	public bool landed;

	void Start()
	{
		// initializing to false
		bossHasItem = false;
		landed = false;
	}

	void OnCollisionEnter(Collision other) {
		// checks to see what object collided with it. 
		// if it's the player then it sets it to a trigger
		// and kinematic so it doesn't fall through the terrian
		if (other.gameObject.CompareTag("Player"))
		{
			landed = true;
			popCan.GetComponent<Collider>().isTrigger = true;
			popCan.GetComponent<Rigidbody>().isKinematic = true;
		}
	} 

	// when inside the trigger area things happen
	void OnTriggerStay(Collider other) 
	{
		// check for player
		if (other.gameObject.CompareTag("Player")) 
		{	
			// brings up the popup window for the popcan
			popUpWindow.SetActive(true);
			
			// on enter it loads to different scene depending on current scene
			if(Input.GetKey("return"))
			{
				Scene CurrentScene = SceneManager.GetActiveScene();
				
				if (CurrentScene.name == "SchoolScene") {
					SceneManager.LoadScene("DinosaurScene");
				}
				else 
				{
					SceneManager.LoadScene("CongratulationsScene");
				}
			
			}

		}
	}

	// when out of the trigger sets the popup window to not active
	void OnTriggerExit(Collider other)
	{
		popUpWindow.SetActive(false);
	}

	void Update ()
	{
		// if both the boss has item and the item hasn't collided with the player
		// other this resets and can't collect the item
		if(bossHasItem && !landed)
		{
			// transform it to fall off the boss
			// needs gravity on and kinematic off and trigger off to land on ground right
			popCan.transform.SetParent(null);
			popCan.GetComponent<Rigidbody>().isKinematic = false;
			popCan.GetComponent<Rigidbody>().useGravity = true;
			popCan.GetComponent<Collider>().isTrigger = false;
			popCan.GetComponent<Rigidbody>().AddForce(-boss.transform.forward * 5);
		}
	}
}


