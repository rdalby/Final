using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using System.Collections.Generic;

// This is the code for the NPCs to give out instructions to the player
// also to edit their animations and popups
public class NPC : MonoBehaviour
{
    // sets the elements of the scene
    public TMP_Text PopUpName;
    public TMP_Text PopUpText;
    public Animator m_Animator;
    public GameObject popUp;

	void Start (){
        // gets the animator component used later
		m_Animator = GetComponent<Animator>();

        // sets the popup back to not active (hidden) and text to blank just to be safe
        popUp.SetActive(false);
        PopUpName.text = "";
        PopUpText.text = "";
	}

    void OnTriggerEnter(Collider other)
    {
        // only do the popup if the thing colliding with it is the player
        /// had to put this in there as I was getting some issues with ground collision
        if (other.gameObject.CompareTag("Player"))
        {
            TextHint();
        }
    }

    void OnTriggerExit(Collider other)
    {
        // only delete the popup if the thing stopping colliding with it is the player
        /// had to put this in there as I was getting some issues with ground collision
        if (other.gameObject.CompareTag("Player"))
        {
            TextDelete();
        }
    }

    void TextHint()
    {
        // sets the popup back to active (visible)
        popUp.SetActive(true);

        // depending on the NPC depends on their message
        if (this.gameObject.name == "Classmate")
        {
            PopUpName.text = "Classmate";
            PopUpText.text = "The history teacher needs your help in his office";
        }else if (this.gameObject.name == "Principal") 
        {
            // adjusts the animator's inTrigger bool to go to proper animation
		    m_Animator.SetBool("inTrigger", true);
            PopUpName.text = "Principal";
            PopUpText.text = "You know where the history teacher's office is..... Go on upstairs";
        }else if (this.gameObject.name == "EnglishTeacher") 
        {
            PopUpName.text = "English Teacher";
            PopUpText.text = "I'm not sure why he wants you something about a discovery.";
        }else if (this.gameObject.name == "HistoryTeacher") 
        {
            PopUpName.text = "History Teacher";
            PopUpText.text = "*mumbling* drink the can.... go back in time... hmmm... but what can does what time.... it can't be real... *to you* go check the shelf!";
        }
       
    }

    void TextDelete()
    {
        // sets the popup back to not active (hidden), text to blank
        popUp.SetActive(false);
        PopUpName.text = "";
        PopUpText.text = "";

        if (this.gameObject.name == "Principal")
        {
            // adjusts the animator's inTrigger bool to go to proper animation
		    m_Animator.SetBool("inTrigger", false);
        }
    }
}
